using System.Windows.Forms;
using Noter.Models;

namespace Noter.Forms
{
    public sealed partial class EditNoteForm : Form
    {
        public string Title
        {
            get { return _note.Title; }
            set
            {
                _note.Title = value;
                titleTextBox.Text = value;
            }
        }

        public string Data
        {
            get { return _note.Data; }
            set
            {
                _note.Data = value;
                dataTextBox.Text = value;
            }
        }

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

        private void okButton_Click(object sender, System.EventArgs e)
        {
            Title = titleTextBox.Text;
            Data = dataTextBox.Text;

            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}