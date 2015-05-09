using System;
using System.Text;
using System.Windows.Forms;

namespace Noter.Forms
{
    public partial class InputPasswordForm : Form
    {
        public byte[] PasswordBytes
        {
            get
            {
                return Encoding.UTF8.GetBytes(passwordTextBox.Text);
            }
        }

        public InputPasswordForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}