using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Noter.Core.Models;

namespace Noter.Core.Extensions
{
    public static class ListViewExtensions
    {
        public static void AddNote(this ListView listView, Note note)
        {
            listView.Items.Add(note.ToListViewItem());
        }

        public static void AddNotes(this ListView listView, IEnumerable<Note> notes)
        {
            var items = notes.Select(note => note.ToListViewItem());
            listView.Items.AddRange(items.ToArray());
        }     
    }
}