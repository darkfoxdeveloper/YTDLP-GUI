using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YTDLP_GUI
{
    public partial class PromptBox : Form
    {
        public string Input { get; set; }
        public PromptBox()
        {
            InitializeComponent();
        }

        private void PromptBox_Load(object sender, EventArgs e)
        {

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Input = textBox1.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
