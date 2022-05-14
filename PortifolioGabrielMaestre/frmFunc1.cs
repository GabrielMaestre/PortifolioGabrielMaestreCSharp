using System;
using System.Windows.Forms;

namespace PortifolioGabrielMaestre
{
    public partial class frmFunc1 : Form
    {
        public frmFunc1()
        {
            InitializeComponent();
        }

        int _Ms = 100, _Sec = 0, _Min = 0, _Hour = 0;

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerGeral.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timerGeral.Stop();
            _Ms = 0;
            _Sec = 0;
            _Min = 0;
            _Hour = 0;
            lblTimer.Text = "00:00:00.000";
        }

        private void timerSec_Tick(object sender, EventArgs e)
        {
            if (_Sec == 60)
            {
                _Sec = 0;
                _Min += 1;
            }
            if (_Min == 60)
            {
                _Min = 0;
                _Hour += 1;
            }
            if (_Hour == 24)
            {
                MessageBox.Show("Lá se vai 1 Dia nisso cara? Vamos parando!", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);
                timerGeral.Stop();
            }
            _Sec += 1;
            lblTimer.Text = $"{_Hour}:{_Min}:{_Sec}";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timerGeral.Start();//EM MS
            //timerSec.Start();//EM SEGUNDOS
        }
        private void timerGeral_Tick(object sender, EventArgs e)
        {
            if (_Ms >= 1000)
            {
                _Sec += 1;
                _Ms = 0;
            }

            lblTimer.Text = $"{_Hour}:{_Min}:{_Sec}.{_Ms}";
            _Ms += 100;

            if (_Sec == 60)
            {
                _Min += 1;
                _Sec = 0;
            }
            if(_Min == 60)
            {
                _Min = 0;
                _Hour += 1;
            }
            if(_Hour == 24)
            {
                MessageBox.Show("Lá se vai 1 Dia nisso cara? Vamos parando!", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);
                timerGeral.Stop();
            }
        }
    }
}
