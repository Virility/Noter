using System;
using System.IO;

namespace Noter.Helpers
{
    public static class Config
    {
        private const string FileName = "Noter.nt";

        public const string ApplicationName = "Noter";
        public const string NewNoteTitle = "New Note!";
        public const string DecryptionFailedError
            = "Decryption failed. Would you like to close Noter? " +
              "Pressing no will result in the deletion of your previous " +
              "notes.";
        public readonly static string NoterFile =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), FileName);

        public static readonly byte[] PrimeNumbers =
        {
            2, 3, 5, 7, 11, 13, 17, 19,
            23, 29, 31, 37, 41, 43, 47, 53
        };

    }
}
