using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using Noter.Core.Extensions;
using Noter.Core.Helpers;
using Noter.Core.Models;
using Noter.UI.Controls;
using Aes = Noter.Core.Helpers.Aes;

namespace Noter.UI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(Config.NoterFile))
                {
                    File.Create(Config.NoterFile);
                    return;
                }

                var fileBytes = File.ReadAllBytes(Config.NoterFile);
                if (fileBytes.Length != 0)
                {
                    try
                    {
                        using (var inputPasswordForm = new InputPasswordForm())
                        {
                            if (inputPasswordForm.ShowDialog() == DialogResult.OK)
                                fileBytes = Aes.Decrypt(fileBytes, inputPasswordForm.PasswordBytes);
                        }

                        var notes = NoteSerializer.Deserialize(fileBytes);
                        notesListView.AddNotes(notes);
                    }
                    catch (CryptographicException)
                    {
                        if (QuestionAsker.Ask(Config.DecryptionFailedError))
                            Environment.Exit(0);
                        else
                            File.Delete(Config.NoterFile);
                    }
                }                                  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                var notes = notesListView.Items.
                    Cast<NoteViewItem>().
                    Select(i => i.Note). 
                    ToArray();

                if (notes.Length == 0)
                    return;

                var fileBytes = NoteSerializer.Serialize(notes);
                using (var inputPasswordForm = new InputPasswordForm())
                {
                    if (inputPasswordForm.ShowDialog() == DialogResult.OK)
                        fileBytes = Aes.Encrypt(fileBytes, inputPasswordForm.PasswordBytes);
                }

                File.WriteAllBytes(Config.NoterFile, fileBytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void notesListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var hitInfo = notesListView.HitTest(e.Location);
            if (hitInfo.Item != null)
                EditNote((NoteViewItem) hitInfo.Item);
        }

        public static void EditNote(NoteViewItem item)
        {        
            item.Note = EditNoteForm.Open(item.Note);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {                                
            var note = Note.NewNote();

            notesListView.AddNote(note);
            EditNote((NoteViewItem) note.ToListViewItem());
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notesListView.SelectedItems.Count != 0)
                EditNote((NoteViewItem) notesListView.SelectedItems[0]);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notesListView.SelectedItems.Count == 0)
                return;

            foreach (ListViewItem item in notesListView.SelectedItems)
                notesListView.Items.Remove(item);
        }
    }
}
