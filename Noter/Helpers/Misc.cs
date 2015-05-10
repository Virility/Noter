using System.Windows.Forms;

namespace Noter.Helpers
{
    public static class Misc
    {
        public static bool AskQuestion(string question)
        {
            var result = MessageBox.Show(
                                            question,
                                            Config.ApplicationName,
                                            MessageBoxButtons.YesNo, 
                                            MessageBoxIcon.Question,
                                            MessageBoxDefaultButton.Button1);

            return (result == DialogResult.Yes);
        }
    }
}