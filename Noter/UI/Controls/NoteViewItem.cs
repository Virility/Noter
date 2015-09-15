using System.Windows.Forms;
using Noter.Core.Models;

namespace Noter.UI.Controls
{
    public class NoteViewItem : ListViewItem
    {          
        private Note _note;  
        public Note Note
        {
            get { return _note; }
            set
            {
                _note = value;
                if (value == null)
                    return;
    
                SubItems.Clear();

                Text = value.Title;
                SubItems.Add(value.Created.ToString("MM/dd/yy hh:mm tt"));
            }
        }

        public NoteViewItem(Note note)
        {
            Note = note;

            Text = note.Title;
            SubItems.Add(note.Created.ToString("MM/dd/yy hh:mm tt"));
        }
    }
}        