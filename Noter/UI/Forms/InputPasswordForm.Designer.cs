using Noter.UI.Controls;

namespace Noter.UI.Forms
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
                components.Dispose();
            
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
            this.noterPanel1 = new NoterPanel();
            this.hidePasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.passwordTextBox = new NoterTextBox();
            this.noterPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // noterPanel1
            // 
            this.noterPanel1.BackColor = System.Drawing.Color.White;
            this.noterPanel1.Controls.Add(this.hidePasswordCheckBox);
            this.noterPanel1.Controls.Add(this.exitButton);
            this.noterPanel1.Controls.Add(this.okButton);
            this.noterPanel1.Controls.Add(this.logoPictureBox);
            this.noterPanel1.Controls.Add(this.passwordTextBox);
            this.noterPanel1.Location = new System.Drawing.Point(12, 12);
            this.noterPanel1.Name = "noterPanel1";
            this.noterPanel1.Size = new System.Drawing.Size(316, 233);
            this.noterPanel1.TabIndex = 0;
            this.noterPanel1.Text = "noterPanel1";
            // 
            // hidePasswordCheckBox
            // 
            this.hidePasswordCheckBox.AutoSize = true;
            this.hidePasswordCheckBox.Checked = true;
            this.hidePasswordCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hidePasswordCheckBox.Location = new System.Drawing.Point(35, 164);
            this.hidePasswordCheckBox.Name = "hidePasswordCheckBox";
            this.hidePasswordCheckBox.Size = new System.Drawing.Size(109, 17);
            this.hidePasswordCheckBox.TabIndex = 9;
            this.hidePasswordCheckBox.Text = "Hide Password";
            this.hidePasswordCheckBox.UseVisualStyleBackColor = true;
            this.hidePasswordCheckBox.CheckedChanged += new System.EventHandler(this.hidePasswordCheckBox_CheckedChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(35, 187);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit..";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(161, 187);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(120, 23);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK..";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.White;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(118, 22);
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
            this.passwordTextBox.Location = new System.Drawing.Point(35, 123);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.Size = new System.Drawing.Size(246, 35);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.EnterKeyPressed += new System.EventHandler(this.passwordTextBox_EnterKeyPressed);
            // 
            // InputPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(110)))), ((int)(((byte)(121)))));
            this.ClientSize = new System.Drawing.Size(340, 257);
            this.Controls.Add(this.noterPanel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InputPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Noter - Input Password";
            this.noterPanel1.ResumeLayout(false);
            this.noterPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.NoterPanel noterPanel1;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private Controls.NoterTextBox passwordTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.CheckBox hidePasswordCheckBox;
    }
}