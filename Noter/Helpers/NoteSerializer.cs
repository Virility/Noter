using System;
using System.IO;
using Noter.Models;

namespace Noter.Helpers
{
    public static class NoteSerializer
    {
        public static byte[] Serialize(params Note[] notes)
        {
            using (var stream = new MemoryStream())
            using (var writer = new BinaryWriter(stream))
            {
                writer.Write(notes.Length);

                foreach (var note in notes)
                {
                    writer.Write(note.Title);
                    writer.Write(note.Data);
                    writer.Write(note.Created.ToBinary());
                }

                return stream.ToArray();
            }
        }

        public static Note[] Deserialize(byte[] inputBytes)
        {
            using (var stream = new MemoryStream(inputBytes))
            using (var reader = new BinaryReader(stream))
            {
                var notes = new Note[reader.ReadInt32()];

                for (var i = 0; i < notes.Length; i++)
                {
                    var title = reader.ReadString();
                    var data = reader.ReadString();
                    var created = DateTime.FromBinary(reader.ReadInt64());

                    notes[i] = new Note(title, data, created);
                }

                return notes;
            }
        }
    }
}