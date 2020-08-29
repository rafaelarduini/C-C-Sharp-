using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class FrmWebBrowser : Form
    {
        public FrmWebBrowser()
        {
            InitializeComponent();
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://pt-br.facebook.com/");
        }

        private void btnYouTube_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://www.youtube.com/?hl=pt&gl=BR");

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmWebBrowser_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
