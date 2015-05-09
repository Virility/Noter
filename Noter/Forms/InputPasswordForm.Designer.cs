namespace Noter.Forms
{
    partial class InputPasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputPasswordForm));
            this.noterPanel1 = new Noter.Controls.NoterPanel();
            this.exitButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.passwordTextBox = new Noter.Controls.NoterTextBox();
            this.noterPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // noterPanel1
            // 
            this.noterPanel1.Controls.Add(this.exitButton);
            this.noterPanel1.Controls.Add(this.loginButton);
            this.noterPanel1.Controls.Add(this.logoPictureBox);
            this.noterPanel1.Controls.Add(this.passwordTextBox);
            this.noterPanel1.Location = new System.Drawing.Point(12, 12);
            this.noterPanel1.Name = "noterPanel1";
            this.noterPanel1.Size = new System.Drawing.Size(316, 233);
            this.noterPanel1.TabIndex = 0;
            this.noterPanel1.Text = "noterPanel1";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(35, 176);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit..";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(161, 176);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(120, 23);
            this.loginButton.TabIndex = 8;
            this.loginButton.Text = "Login..";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.White;
            this.logoPictureBox.Image = global::Noter.Properties.Resources.icon;
            this.logoPictureBox.Location = new System.Drawing.Point(118, 34);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(80, 80);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 6;
            this.logoPictureBox.TabStop = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.White;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox.Location = new System.Drawing.Point(35, 135);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.Size = new System.Drawing.Size(246, 35);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextBox.UseSystemPasswordChar = false;
            // 
            // InputPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(110)))), ((int)(((byte)(121)))));
            this.ClientSize = new System.Drawing.Size(340, 257);
            this.Controls.Add(this.noterPanel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InputPasswordForm";
            this.Text = "Noter - Input Password";
            this.noterPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.NoterPanel noterPanel1;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private Controls.NoterTextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button exitButton;
    }
}