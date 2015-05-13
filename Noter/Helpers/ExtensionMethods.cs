using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Noter.Models;

namespace Noter.Helpers
{
    public static class ExtensionMethods
    {
        public static void Show(this TabPage tabPage, TabControl tabControl)
        {
            if (!tabControl.TabPages.Contains(tabPage))
                tabControl.TabPages.Add(tabPage);
        }

        public static void Hide(this TabPage tabPage, TabControl tabControl)
        {
            if (tabControl.TabPages.Contains(tabPage))
                tabControl.TabPages.Remove(tabPage);
        }

        public static void AddNote(this ListView listView, Note note)
        {
            listView.Items.Add(note.ToListViewItem());
        }

        public static void AddNotes(this ListView listView, IEnumerable<Note> notes)
        {
            var items = notes.Select(note => note.ToListViewItem());
            listView.Items.AddRange(items.ToArray());
        }

        public static bool IsNull(this byte[] input)
        {
            return (input == null || input.Length == 0);
        }
    }
}