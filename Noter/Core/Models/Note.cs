using System;
using System.Windows.Forms;
using Noter.Core.Helpers;
using Noter.UI.Controls;

namespace Noter.Core.Models
{
    public class Note
    {
        public string Title { get; set; }

        public string Data { get; set; }

        public DateTime Created { get; set; }

        public Note(string title, string data, DateTime created)
        {
            Title = title;
            Data = data;
            Created = created;
        }

        public ListViewItem ToListViewItem()
        {
            return new NoteViewItem(this);
        }

        public static Note NewNote()
        {
            return new Note(Config.NewNoteTitle, string.Empty, DateTime.Now);
        }
    }
}