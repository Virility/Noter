using System;
using System.Windows.Forms;
using Noter.Models;

namespace Noter.Forms
{
    public sealed partial class EditNoteForm : Form
    {
        private Note _note;
        public Note Note
        {
            get { return _note; }
            set
            {
                _note = value;

                titleTextBox.Text = value.Title;
                dataTextBox.Text = value.Data;
            }
        }

        public EditNoteForm(Note note)
        {
            InitializeComponent();

            Text = string.Format(Text, note.Title);
            Note = note;
        }

        public static Note Open(Note note)
        {
            using (var editNoteForm = new EditNoteForm(note))
                return editNoteForm.ShowDialog() == DialogResult.OK ? editNoteForm.Note : note;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            var title = titleTextBox.Text;
            var data = dataTextBox.Text;

            _note = new Note(title, data, _note.Created);
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}