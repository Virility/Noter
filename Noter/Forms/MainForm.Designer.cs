using System.Windows.Forms;

namespace Noter.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.netSealTabControl1 = new Noter.Controls.NoterTabControl();
            this.notesTabPage = new System.Windows.Forms.TabPage();
            this.notesListView = new System.Windows.Forms.ListView();
            this.titleColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateCreatedColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loginTabPage = new System.Windows.Forms.TabPage();
            this.loginButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.encryptCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordTextBox = new Noter.Controls.NoterTextBox();
            this.MainContextMenuStrip.SuspendLayout();
            this.netSealTabControl1.SuspendLayout();
            this.notesTabPage.SuspendLayout();
            this.loginTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainContextMenuStrip
            // 
            this.MainContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.openToolStripMenuItem});
            this.MainContextMenuStrip.Name = "MainContextMenuStrip";
            this.MainContextMenuStrip.Size = new System.Drawing.Size(118, 70);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // netSealTabControl1
            // 
            this.netSealTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.netSealTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.netSealTabControl1.Controls.Add(this.notesTabPage);
            this.netSealTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.netSealTabControl1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.netSealTabControl1.ItemSize = new System.Drawing.Size(30, 115);
            this.netSealTabControl1.Location = new System.Drawing.Point(8, 8);
            this.netSealTabControl1.Multiline = true;
            this.netSealTabControl1.Name = "netSealTabControl1";
            this.netSealTabControl1.SelectedIndex = 0;
            this.netSealTabControl1.Size = new System.Drawing.Size(499, 286);
            this.netSealTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.netSealTabControl1.TabIndex = 0;
            // 
            // notesTabPage
            // 
            this.notesTabPage.BackColor = System.Drawing.Color.White;
            this.notesTabPage.Controls.Add(this.notesListView);
            this.notesTabPage.Location = new System.Drawing.Point(119, 4);
            this.notesTabPage.Name = "notesTabPage";
            this.notesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.notesTabPage.Size = new System.Drawing.Size(376, 278);
            this.notesTabPage.TabIndex = 1;
            this.notesTabPage.Text = "My Notes";
            // 
            // notesListView
            // 
            this.notesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleColumnHeader,
            this.dateCreatedColumnHeader});
            this.notesListView.ContextMenuStrip = this.MainContextMenuStrip;
            this.notesListView.FullRowSelect = true;
            this.notesListView.Location = new System.Drawing.Point(4, 3);
            this.notesListView.Name = "notesListView";
            this.notesListView.Size = new System.Drawing.Size(368, 269);
            this.notesListView.TabIndex = 0;
            this.notesListView.UseCompatibleStateImageBehavior = false;
            this.notesListView.View = System.Windows.Forms.View.Details;
            this.notesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notesListView_MouseDoubleClick);
            // 
            // titleColumnHeader
            // 
            this.titleColumnHeader.Text = "Title";
            this.titleColumnHeader.Width = 203;
            // 
            // dateCreatedColumnHeader
            // 
            this.dateCreatedColumnHeader.Text = "Created";
            this.dateCreatedColumnHeader.Width = 132;
            // 
            // loginTabPage
            // 
            this.loginTabPage.BackColor = System.Drawing.Color.White;
            this.loginTabPage.Controls.Add(this.loginButton);
            this.loginTabPage.Controls.Add(this.pictureBox1);
            this.loginTabPage.Controls.Add(this.encryptCheckBox);
            this.loginTabPage.Controls.Add(this.passwordTextBox);
            this.loginTabPage.Location = new System.Drawing.Point(119, 4);
            this.loginTabPage.Name = "loginTabPage";
            this.loginTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.loginTabPage.Size = new System.Drawing.Size(376, 278);
            this.loginTabPage.TabIndex = 2;
            this.loginTabPage.Text = "Login";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(206, 210);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(105, 23);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login..";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Noter.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(148, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // encryptCheckBox
            // 
            this.encryptCheckBox.AutoSize = true;
            this.encryptCheckBox.Location = new System.Drawing.Point(65, 187);
            this.encryptCheckBox.Name = "encryptCheckBox";
            this.encryptCheckBox.Size = new System.Drawing.Size(62, 17);
            this.encryptCheckBox.TabIndex = 1;
            this.encryptCheckBox.Text = "Encrypt";
            this.encryptCheckBox.UseVisualStyleBackColor = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox.Location = new System.Drawing.Point(65, 146);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.Size = new System.Drawing.Size(246, 35);
            this.passwordTextBox.TabIndex = 0;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextBox.UseSystemPasswordChar = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(110)))), ((int)(((byte)(121)))));
            this.ClientSize = new System.Drawing.Size(514, 302);
            this.Controls.Add(this.netSealTabControl1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Noter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainContextMenuStrip.ResumeLayout(false);
            this.netSealTabControl1.ResumeLayout(false);
            this.notesTabPage.ResumeLayout(false);
            this.loginTabPage.ResumeLayout(false);
            this.loginTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.NoterTabControl netSealTabControl1;
        private System.Windows.Forms.TabPage notesTabPage;
        private System.Windows.Forms.ListView notesListView;
        private System.Windows.Forms.ColumnHeader titleColumnHeader;
        private System.Windows.Forms.ContextMenuStrip MainContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TabPage loginTabPage;
        private System.Windows.Forms.CheckBox encryptCheckBox;
        private Controls.NoterTextBox passwordTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ToolStripMenuItem removeToolStripMenuItem;
        private ColumnHeader dateCreatedColumnHeader;
        private Button loginButton;
    }
}