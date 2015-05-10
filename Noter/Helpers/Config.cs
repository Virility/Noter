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
            = "Decryption failed. Would you like to close Noter? Saying no will result in the deletion of your previous notes file.";
        public readonly static string NoterFile =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), FileName);
    }
}