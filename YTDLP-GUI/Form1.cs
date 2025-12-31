using System.Diagnostics;

namespace YTDLP_GUI
{
    // winget install "FFmpeg (Essentials Build)"   requerimiento
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lstDownloadURIs.Items.Clear();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            foreach (string uri in lstDownloadURIs.Items)
            {
                if (!uri.StartsWith("http://") && !uri.StartsWith("https://")) continue;
                Process p = Process.Start(
                    new ProcessStartInfo() { 
                        FileName = "ytdlp.exe",
                        Arguments = uri,
                        RedirectStandardOutput = false
                    });
                p.WaitForExit();
                //string output = p.StandardOutput.ReadToEnd();
                //MessageBox.Show(output);
            }
        }

        private void BtnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (lstDownloadURIs.SelectedItem != null)
            {
                lstDownloadURIs.Items.Remove(lstDownloadURIs.SelectedItem);
            }
        }

        private void BtnAddToDownload_Click(object sender, EventArgs e)
        {
            var dialog = new PromptBox();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                lstDownloadURIs.Items.Add(dialog.Input);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("ytdlp.exe"))
            {
                File.WriteAllBytes("ytdlp.exe", Properties.Resources.ytdlp);
            }
        }
    }
}
