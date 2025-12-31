namespace YTDLP_GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddToDownload = new Button();
            btnStart = new Button();
            lstDownloadURIs = new ListBox();
            btnSettings = new Button();
            btnRemoveSelected = new Button();
            SuspendLayout();
            // 
            // btnAddToDownload
            // 
            btnAddToDownload.Location = new Point(492, 301);
            btnAddToDownload.Name = "btnAddToDownload";
            btnAddToDownload.Size = new Size(223, 46);
            btnAddToDownload.TabIndex = 0;
            btnAddToDownload.Text = "Add to Download";
            btnAddToDownload.UseVisualStyleBackColor = true;
            btnAddToDownload.Click += BtnAddToDownload_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(724, 301);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(195, 46);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start Download";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += BtnStart_Click;
            // 
            // lstDownloadURIs
            // 
            lstDownloadURIs.FormattingEnabled = true;
            lstDownloadURIs.Location = new Point(12, 12);
            lstDownloadURIs.Name = "lstDownloadURIs";
            lstDownloadURIs.Size = new Size(897, 260);
            lstDownloadURIs.TabIndex = 2;
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(12, 301);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(144, 46);
            btnSettings.TabIndex = 3;
            btnSettings.Text = "Set Auth";
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSelected
            // 
            btnRemoveSelected.Location = new Point(278, 301);
            btnRemoveSelected.Name = "btnRemoveSelected";
            btnRemoveSelected.Size = new Size(208, 46);
            btnRemoveSelected.TabIndex = 4;
            btnRemoveSelected.Text = "Remove selected";
            btnRemoveSelected.UseVisualStyleBackColor = true;
            btnRemoveSelected.Click += BtnRemoveSelected_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 359);
            Controls.Add(btnRemoveSelected);
            Controls.Add(btnSettings);
            Controls.Add(lstDownloadURIs);
            Controls.Add(btnStart);
            Controls.Add(btnAddToDownload);
            Name = "Form1";
            Text = "Youtube DLP GUI";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddToDownload;
        private Button btnStart;
        private ListBox lstDownloadURIs;
        private Button btnSettings;
        private Button btnRemoveSelected;
    }
}
