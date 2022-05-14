using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PortifolioGabrielMaestre
{
    public partial class frmSysDetails : Form
    {
        public frmSysDetails()
        {
            InitializeComponent();

            InitialiseCPUCounter();
            InitializeRAMCounter();
        }

        private void frmSysDetails_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private PerformanceCounter cpuCount;
        private PerformanceCounter ramCount;
        private void timer_Tick(object sender, EventArgs e)
        {
            this.lblCpu.Text = "Uso CPU: " + Convert.ToInt32(cpuCount.NextValue()).ToString() + "%";
            this.lblRam.Text = "Memoria Livre: "+ Convert.ToInt32(ramCount.NextValue()).ToString() + "Mb";
        }
        private void InitialiseCPUCounter()
        {
            cpuCount = new PerformanceCounter(
            "Processor",
            "% Processor Time",
            "_Total",
            true
            );
        }

        private void InitializeRAMCounter()
        {
            ramCount = new PerformanceCounter("Memory", "Available MBytes", true);
        }
    }
}
