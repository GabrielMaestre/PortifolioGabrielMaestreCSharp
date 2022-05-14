using System;
using System.Windows.Forms;

using CefSharp;
using CefSharp.WinForms;

namespace PortifolioGabrielMaestre
{
    public partial class frmBrowser : Form
    {
        public frmBrowser()
        {
            InitializeComponent();
            //Start Chromium Web Browser
            InitializeChromium();
        }

        public ChromiumWebBrowser chromeBrowser;

        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();

            Cef.Initialize(settings);

            chromeBrowser = new ChromiumWebBrowser("https://gabrielmaestre.github.io/pinguin-links/");

            this.pnlBrowser.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }

        private void frmBrowser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void frmBrowser_Load(object sender, EventArgs e)
        {

        }
    }
}
