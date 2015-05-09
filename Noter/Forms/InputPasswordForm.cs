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
            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                MessageBox.Show("You must input a password.");
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void hidePasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = hidePasswordCheckBox.Checked;
        }
    }
}