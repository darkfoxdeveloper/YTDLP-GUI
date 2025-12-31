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
            tbxLog = new RichTextBox();
            SuspendLayout();
            // 
            // btnAddToDownload
            // 
            btnAddToDownload.Location = new Point(371, 141);
            btnAddToDownload.Margin = new Padding(2, 1, 2, 1);
            btnAddToDownload.Name = "btnAddToDownload";
            btnAddToDownload.Size = new Size(120, 22);
            btnAddToDownload.TabIndex = 0;
            btnAddToDownload.Text = "Add to Download";
            btnAddToDownload.UseVisualStyleBackColor = true;
            btnAddToDownload.Click += BtnAddToDownload_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(609, 141);
            btnStart.Margin = new Padding(2, 1, 2, 1);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(105, 22);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start Download";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += BtnStart_Click;
            // 
            // lstDownloadURIs
            // 
            lstDownloadURIs.FormattingEnabled = true;
            lstDownloadURIs.ItemHeight = 15;
            lstDownloadURIs.Location = new Point(6, 6);
            lstDownloadURIs.Margin = new Padding(2, 1, 2, 1);
            lstDownloadURIs.Name = "lstDownloadURIs";
            lstDownloadURIs.Size = new Size(708, 124);
            lstDownloadURIs.TabIndex = 2;
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(6, 141);
            btnSettings.Margin = new Padding(2, 1, 2, 1);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(140, 22);
            btnSettings.TabIndex = 3;
            btnSettings.Text = "Set Auth";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += BtnSettings_Click;
            // 
            // btnRemoveSelected
            // 
            btnRemoveSelected.Location = new Point(256, 141);
            btnRemoveSelected.Margin = new Padding(2, 1, 2, 1);
            btnRemoveSelected.Name = "btnRemoveSelected";
            btnRemoveSelected.Size = new Size(112, 22);
            btnRemoveSelected.TabIndex = 4;
            btnRemoveSelected.Text = "Remove selected";
            btnRemoveSelected.UseVisualStyleBackColor = true;
            btnRemoveSelected.Click += BtnRemoveSelected_Click;
            // 
            // tbxLog
            // 
            tbxLog.BackColor = SystemColors.ControlText;
            tbxLog.BorderStyle = BorderStyle.None;
            tbxLog.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxLog.ForeColor = SystemColors.Control;
            tbxLog.Location = new Point(6, 167);
            tbxLog.Name = "tbxLog";
            tbxLog.Size = new Size(716, 266);
            tbxLog.TabIndex = 5;
            tbxLog.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 437);
            Controls.Add(tbxLog);
            Controls.Add(btnRemoveSelected);
            Controls.Add(btnSettings);
            Controls.Add(lstDownloadURIs);
            Controls.Add(btnStart);
            Controls.Add(btnAddToDownload);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
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
        private RichTextBox tbxLog;
    }
}
