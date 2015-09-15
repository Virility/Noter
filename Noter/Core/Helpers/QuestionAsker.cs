using System.Windows.Forms;

namespace Noter.Core.Helpers
{
    public static class QuestionAsker
    {
        public static bool Ask(string question)
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