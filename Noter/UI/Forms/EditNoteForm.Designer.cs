using Noter.UI.Controls;

namespace Noter.UI.Forms
{
    sealed partial class EditNoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditNoteForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.dataTextBox = new NoterTextBox();
            this.titleTextBox = new NoterTextBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(242, 230);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(101, 25);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel..";
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(349, 230);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(101, 25);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK..";
            this.okButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // dataTextBox
            // 
            this.dataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dataTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataTextBox.ForeColor = System.Drawing.Color.Black;
            this.dataTextBox.Location = new System.Drawing.Point(14, 53);
            this.dataTextBox.MaxLength = 32767;
            this.dataTextBox.Multiline = true;
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.ReadOnly = false;
            this.dataTextBox.Size = new System.Drawing.Size(436, 171);
            this.dataTextBox.TabIndex = 1;
            this.dataTextBox.Text = "notesTextBox";
            this.dataTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dataTextBox.UseSystemPasswordChar = false;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.titleTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.titleTextBox.ForeColor = System.Drawing.Color.Black;
            this.titleTextBox.Location = new System.Drawing.Point(14, 12);
            this.titleTextBox.MaxLength = 32767;
            this.titleTextBox.Multiline = false;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = false;
            this.titleTextBox.Size = new System.Drawing.Size(264, 35);
            this.titleTextBox.TabIndex = 0;
            this.titleTextBox.Text = "titleTextBox";
            this.titleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.titleTextBox.UseSystemPasswordChar = false;
            // 
            // EditNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(110)))), ((int)(((byte)(121)))));
            this.ClientSize = new System.Drawing.Size(464, 267);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditNoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Noter - Edit \"{0}\"";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.NoterTextBox titleTextBox;
        private Controls.NoterTextBox dataTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
    }
}