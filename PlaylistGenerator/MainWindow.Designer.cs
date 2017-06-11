namespace PlaylistGenerator
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.folderBrowserButton = new System.Windows.Forms.Button();
			this.MP3Path = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ExitButton = new System.Windows.Forms.Button();
			this.toolTipBrowser = new System.Windows.Forms.ToolTip(this.components);
			this.generatePlaylist = new System.Windows.Forms.Button();
			this.overwritePlayList = new System.Windows.Forms.CheckBox();
			this.createOneList = new System.Windows.Forms.CheckBox();
			this.trimFilename = new System.Windows.Forms.CheckBox();
			this.numFileChars = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// folderBrowserDialog
			// 
			this.folderBrowserDialog.ShowNewFolderButton = false;
			this.folderBrowserDialog.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
			// 
			// folderBrowserButton
			// 
			this.folderBrowserButton.Location = new System.Drawing.Point(316, 18);
			this.folderBrowserButton.Name = "folderBrowserButton";
			this.folderBrowserButton.Size = new System.Drawing.Size(24, 23);
			this.folderBrowserButton.TabIndex = 1;
			this.folderBrowserButton.Text = "...";
			this.folderBrowserButton.UseVisualStyleBackColor = true;
			this.folderBrowserButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onFolderBrowseButton);
			// 
			// MP3Path
			// 
			this.MP3Path.Location = new System.Drawing.Point(10, 19);
			this.MP3Path.Name = "MP3Path";
			this.MP3Path.ReadOnly = true;
			this.MP3Path.Size = new System.Drawing.Size(300, 20);
			this.MP3Path.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.MP3Path);
			this.groupBox1.Controls.Add(this.folderBrowserButton);
			this.groupBox1.Location = new System.Drawing.Point(12, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(352, 60);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Select Folder";
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(289, 179);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(75, 23);
			this.ExitButton.TabIndex = 1;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.onExitButton);
			// 
			// toolTipBrowser
			// 
			this.toolTipBrowser.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			// 
			// generatePlaylist
			// 
			this.generatePlaylist.Location = new System.Drawing.Point(208, 179);
			this.generatePlaylist.Name = "generatePlaylist";
			this.generatePlaylist.Size = new System.Drawing.Size(75, 23);
			this.generatePlaylist.TabIndex = 0;
			this.generatePlaylist.Text = "Generate";
			this.generatePlaylist.UseVisualStyleBackColor = true;
			this.generatePlaylist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onGeneratePlaylist);
			// 
			// overwritePlayList
			// 
			this.overwritePlayList.AutoSize = true;
			this.overwritePlayList.Location = new System.Drawing.Point(22, 74);
			this.overwritePlayList.Name = "overwritePlayList";
			this.overwritePlayList.Size = new System.Drawing.Size(147, 17);
			this.overwritePlayList.TabIndex = 3;
			this.overwritePlayList.Text = "overwrite existing Playlists";
			this.overwritePlayList.UseVisualStyleBackColor = true;
			// 
			// createOneList
			// 
			this.createOneList.AutoSize = true;
			this.createOneList.Location = new System.Drawing.Point(22, 98);
			this.createOneList.Name = "createOneList";
			this.createOneList.Size = new System.Drawing.Size(79, 17);
			this.createOneList.TabIndex = 4;
			this.createOneList.Text = "one Playlist";
			this.createOneList.UseVisualStyleBackColor = true;
			// 
			// trimFilename
			// 
			this.trimFilename.AutoSize = true;
			this.trimFilename.Location = new System.Drawing.Point(22, 122);
			this.trimFilename.Name = "trimFilename";
			this.trimFilename.Size = new System.Drawing.Size(96, 17);
			this.trimFilename.TabIndex = 5;
			this.trimFilename.Text = "trim filename to";
			this.trimFilename.UseVisualStyleBackColor = true;
			// 
			// numFileChars
			// 
			this.numFileChars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numFileChars.Location = new System.Drawing.Point(119, 120);
			this.numFileChars.Name = "numFileChars";
			this.numFileChars.Size = new System.Drawing.Size(32, 20);
			this.numFileChars.TabIndex = 6;
			this.numFileChars.Text = "60";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(153, 124);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "chars";
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(376, 214);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numFileChars);
			this.Controls.Add(this.trimFilename);
			this.Controls.Add(this.createOneList);
			this.Controls.Add(this.overwritePlayList);
			this.Controls.Add(this.generatePlaylist);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainWindow";
			this.Text = "MP3 Playlist Editor";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button folderBrowserButton;
        private System.Windows.Forms.TextBox MP3Path;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ToolTip toolTipBrowser;
        private System.Windows.Forms.Button generatePlaylist;
        private System.Windows.Forms.CheckBox overwritePlayList;
		private System.Windows.Forms.CheckBox createOneList;
		private System.Windows.Forms.CheckBox trimFilename;
		private System.Windows.Forms.TextBox numFileChars;
		private System.Windows.Forms.Label label1;
    }
}

