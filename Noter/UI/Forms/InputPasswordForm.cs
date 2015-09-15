using System;
using System.Text;
using System.Windows.Forms;

namespace Noter.UI.Forms
{
    public partial class InputPasswordForm : Form
    {
        public InputPasswordForm()
        {
            InitializeComponent();
        }

        public byte[] PasswordBytes
        {
            get
            {
                return Encoding.UTF8.GetBytes(passwordTextBox.Text);
            }
        }

        private void passwordTextBox_EnterKeyPressed(object sender, EventArgs e)
        {
            okButton.PerformClick();
        }

        private void hidePasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = hidePasswordCheckBox.Checked;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                MessageBox.Show(@"You must input a password.");
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}