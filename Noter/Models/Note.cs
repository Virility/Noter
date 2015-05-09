using System;
using System.Windows.Forms;
using Noter.Helpers;

namespace Noter.Models
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
            return new ListViewItem(new[]
            {
                Title, Created.ToString("MM/dd/yy hh:mm tt")
            }) { Tag = this };
        }

        public static Note NewNote()
        {
            return new Note(Config.NewNoteTitle, string.Empty, DateTime.Now);
        }
    }
}