using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Noter.Models;
using Noter.Helpers;
using Aes = Noter.Helpers.Aes;

namespace Noter.Forms
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
                    }
                    catch (CryptographicException)
                    {
                        if (Misc.AskQuestion(Config.DecryptionFailedError))
                            File.Create(Config.NoterFile);
                    }

                    var notes = NoteSerializer.Deserialize(fileBytes);
                    Console.WriteLine(notes.Length);
                    notesListView.AddNotes(notes);
                }

                loginTabPage.Hide(mainTabControl);
                notesTabPage.Show(mainTabControl);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                var notes = notesListView.Items.
                    Cast<ListViewItem>().
                    Where(i => i.Tag is Note).
                    Select(i => i.Tag).
                    Cast<Note>().
                    ToArray();
                
                var fileBytes = NoteSerializer.Serialize(notes);

                try
                {
                    using (var inputPasswordForm = new InputPasswordForm())
                    {
                        if (inputPasswordForm.ShowDialog() == DialogResult.OK)
                            fileBytes = Aes.Encrypt(fileBytes, inputPasswordForm.PasswordBytes);
                    }
                }
                catch (CryptographicException)
                {
                    if (Misc.AskQuestion(Config.DecryptionFailedError))
                        File.Create(Config.NoterFile);
                }

                File.WriteAllBytes(Config.NoterFile, fileBytes);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void notesListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var hit = notesListView.HitTest(e.Location);
            if (hit.Item != null)
                EditNote(hit.Item);
        }

        public static void EditNote(ListViewItem item)
        {
            if (item.Tag != null && item.Tag.GetType() == typeof(Note))
            {
                var editedNote = EditNoteForm.Open((Note)item.Tag);
                item.Text = editedNote.Title;
                item.Tag = editedNote;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = Note.NewNote().ToListViewItem();

            notesListView.Items.Add(item);
            EditNote(item);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notesListView.SelectedItems.Count != 0)
                EditNote(notesListView.SelectedItems[0]);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (notesListView.SelectedItems.Count == 0)
                return;

            foreach (ListViewItem item in notesListView.SelectedItems)
                notesListView.Items.Remove(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}