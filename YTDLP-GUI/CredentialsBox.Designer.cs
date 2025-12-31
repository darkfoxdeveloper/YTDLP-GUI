namespace YTDLP_GUI
{
    partial class CredentialsBox
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
            tbxPassword = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            tbxUsername = new TextBox();
            label1 = new Label();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(6, 100);
            tbxPassword.Margin = new Padding(2, 1, 2, 1);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(423, 23);
            tbxPassword.TabIndex = 0;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(163, 140);
            btnOK.Margin = new Padding(2, 1, 2, 1);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(266, 28);
            btnOK.TabIndex = 1;
            btnOK.Text = "Set Credentials";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += BtnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(7, 140);
            btnCancel.Margin = new Padding(2, 1, 2, 1);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(152, 28);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbxUsername
            // 
            tbxUsername.Location = new Point(6, 34);
            tbxUsername.Margin = new Padding(2, 1, 2, 1);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(423, 23);
            tbxUsername.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(6, 75);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // CredentialsBox
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(431, 173);
            Controls.Add(lblPassword);
            Controls.Add(label1);
            Controls.Add(tbxUsername);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(tbxPassword);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2, 1, 2, 1);
            Name = "CredentialsBox";
            Text = "Credentials";
            Load += PromptBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxPassword;
        private Button btnOK;
        private Button btnCancel;
        private TextBox tbxUsername;
        private Label label1;
        private Label lblPassword;
    }
}