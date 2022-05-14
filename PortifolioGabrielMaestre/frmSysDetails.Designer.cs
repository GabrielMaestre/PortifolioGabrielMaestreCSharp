
namespace PortifolioGabrielMaestre
{
    partial class frmSysDetails
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
            this.components = new System.ComponentModel.Container();
            this.lblRam = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblCpu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRam.Location = new System.Drawing.Point(74, 36);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(60, 24);
            this.lblRam.TabIndex = 0;
            this.lblRam.Text = "label1";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblCpu
            // 
            this.lblCpu.AutoSize = true;
            this.lblCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpu.Location = new System.Drawing.Point(74, 123);
            this.lblCpu.Name = "lblCpu";
            this.lblCpu.Size = new System.Drawing.Size(60, 24);
            this.lblCpu.TabIndex = 1;
            this.lblCpu.Text = "label1";
            // 
            // frmSysDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(510, 198);
            this.Controls.Add(this.lblCpu);
            this.Controls.Add(this.lblRam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSysDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Details";
            this.Load += new System.EventHandler(this.frmSysDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblCpu;
    }
}