
namespace PortifolioGabrielMaestre
{
    partial class frmFunc1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timerGeral = new System.Windows.Forms.Timer(this.components);
            this.timerSec = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.FlatAppearance.BorderSize = 5;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(163, 231);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(178, 54);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START/RESUME";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(84, 101);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(336, 56);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "00:00:00.000";
            // 
            // timerGeral
            // 
            this.timerGeral.Tick += new System.EventHandler(this.timerGeral_Tick);
            // 
            // timerSec
            // 
            this.timerSec.Interval = 1000;
            this.timerSec.Tick += new System.EventHandler(this.timerSec_Tick);
            // 
            // btnStop
            // 
            this.btnStop.FlatAppearance.BorderSize = 5;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(163, 291);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(178, 54);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderSize = 5;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(163, 351);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(178, 54);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmFunc1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(502, 426);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnStart);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmFunc1";
            this.Text = "frmFunc1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timerGeral;
        private System.Windows.Forms.Timer timerSec;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
    }
}