namespace YTDLP_GUI
{
    public partial class CredentialsBox : Form
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public CredentialsBox()
        {
            InitializeComponent();
        }

        private void PromptBox_Load(object sender, EventArgs e)
        {

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Username = tbxUsername.Text;
            Password = tbxPassword.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
