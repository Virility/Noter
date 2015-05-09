using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Noter.Models;
using Noter.Helpers;

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
                    var notes = NoteSerializer.Deserialize(fileBytes);
                    Console.WriteLine(notes.Length);
                    notesListView.AddNotes(notes);
                }

                loginTabPage.Hide(netSealTabControl1);
                notesTabPage.Show(netSealTabControl1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                if (Misc.AskQuestion(Config.DecryptionFailedError))
                    File.Create(Config.NoterFile);
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

                File.WriteAllBytes(Config.NoterFile, NoteSerializer.Serialize(notes));
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
            if (notesListView.SelectedItems.Count != 0)
                notesListView.Items.Remove(notesListView.SelectedItems[0]);
        }
    }
}