using System.Diagnostics;

namespace YTDLP_GUI
{
    // winget install "FFmpeg (Essentials Build)"   requerimiento
    public partial class Form1 : Form
    {
        private string AuthArgs = "";
        public Form1()
        {
            InitializeComponent();
            lstDownloadURIs.Items.Clear();
        }

        private async void BtnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            List<string> itemsToRemove = new List<string>();

            try
            {
                foreach (string uri in lstDownloadURIs.Items)
                {
                    if (!uri.StartsWith("http://") && !uri.StartsWith("https://"))
                        continue;

                    using (var p = new Process())
                    {
                        p.StartInfo = new ProcessStartInfo
                        {
                            FileName = "ytdlp.exe",
                            Arguments = uri + " " + AuthArgs,
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            RedirectStandardError = true,
                            CreateNoWindow = true
                        };

                        p.OutputDataReceived += (s, ev) =>
                        {
                            if (string.IsNullOrEmpty(ev.Data)) return;
                            tbxLog.BeginInvoke(new Action(() =>
                            {
                                tbxLog.AppendText(ev.Data + Environment.NewLine);
                                tbxLog.ScrollToCaret();
                            }));
                        };

                        p.ErrorDataReceived += (s, ev) =>
                        {
                            if (string.IsNullOrEmpty(ev.Data)) return;
                            tbxLog.BeginInvoke(new Action(() =>
                            {
                                tbxLog.SelectionColor = Color.Red;
                                tbxLog.AppendText(ev.Data + Environment.NewLine);
                                tbxLog.SelectionColor = tbxLog.ForeColor;
                                tbxLog.ScrollToCaret();
                            }));
                        };

                        p.Start();
                        p.BeginOutputReadLine();
                        p.BeginErrorReadLine();

                        await Task.Run(() => p.WaitForExit());
                        p.WaitForExit();
                    }
                    itemsToRemove.Add(uri);
                }

                foreach (string item in itemsToRemove)
                {
                    lstDownloadURIs.Items.Remove(item);
                }

                string exeFolder = AppDomain.CurrentDomain.BaseDirectory;
                Process.Start("explorer.exe", exeFolder);
            }
            finally
            {
                btnStart.Enabled = true;
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

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            var f = new CredentialsBox();
            if (f.ShowDialog() == DialogResult.OK)
            {
                AuthArgs = $"-u {f.Username} -p {f.Password}";
                btnSettings.Text = "Change Auth";
            }
        }
    }
}
