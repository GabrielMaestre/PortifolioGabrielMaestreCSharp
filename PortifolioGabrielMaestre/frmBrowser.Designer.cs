
namespace PortifolioGabrielMaestre
{
    partial class frmBrowser
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
            this.pnlBrowser = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlBrowser
            // 
            this.pnlBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBrowser.Location = new System.Drawing.Point(0, 0);
            this.pnlBrowser.Name = "pnlBrowser";
            this.pnlBrowser.Size = new System.Drawing.Size(692, 557);
            this.pnlBrowser.TabIndex = 0;
            // 
            // frmBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(692, 557);
            this.Controls.Add(this.pnlBrowser);
            this.Name = "frmBrowser";
            this.Text = "Portifolio Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBrowser_FormClosing);
            this.Load += new System.EventHandler(this.frmBrowser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBrowser;
    }
}