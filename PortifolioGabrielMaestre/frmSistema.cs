using System;
using System.Windows.Forms;

namespace PortifolioGabrielMaestre
{
    public partial class frmSistema : Form
    {
        public frmSistema()
        {
            InitializeComponent();
        }

        private void frmSistema_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(4);
        }

        private void lnklblGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/GabrielMaestre/Portifolio_Csharp");
        }

        private void newFunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFunc1 frmFunc = new frmFunc1();
            frmFunc.MdiParent = this;
            frmFunc.Show();
        }

        private void functionSystemDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSysDetails frmSysDt = new frmSysDetails();
            frmSysDt.MdiParent = this;
            frmSysDt.Show();
        }

        private void newFunction3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBrowser frmWeb = new frmBrowser();
            frmWeb.MdiParent = this;
            frmWeb.Show();
        }

        private void functionMySqlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatabase frmMySql = new frmDatabase();
            frmMySql.MdiParent = this;
            frmMySql.Show();
        }
    }
}
