using System;
using System.Drawing;
using System.Windows.Forms;

namespace PortifolioGabrielMaestre
{
    public partial class Login : Form
    {
        int r = 255, g = 255, b = 255;

        private bool mouseDown;
        private Point lastLocation;
        frmSistema frmSis = new frmSistema();

        const string userLogin = "admin";
        const string passLogin = "123";


        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(4);
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUser.Text == userLogin && txtPass.Text == passLogin)
            {
                MessageBox.Show($"Sejá Bem-vindo(a) {userLogin}", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmSis.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Seus dados estão incorretos, tente novamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvider1.SetError(txtUser, "Login Errado");
                errorProvider1.SetError(txtPass, "Senha Errado");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.txtUser, $"Usuario padrão é: {userLogin}");
            toolTip1.SetToolTip(this.txtPass, $"Senha padrão é: {passLogin}");

            toolTip1.SetToolTip(this.lblUser, $"Usuario padrão é: {userLogin}");
            toolTip1.SetToolTip(this.lblPass, $"Senha padrão é: {passLogin}");
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Usuario padrão é: {userLogin}\nSenha padrão é {passLogin}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        //IGNORE
        private void timerRGB1_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(r, g, b);
            lblBackColor.Text = $"RGB ({r}, {g}, {b})";

            //ORIGINAL
            //if (r > 0 && b == 0)
            //{
            //    r--;
            //    g++;
            //}
            //if (g > 0 && r == 0)
            //{
            //    g--;
            //    b++;
            //}
            //if (b > 0 && g == 0)
            //{
            //    b--;
            //    r++;
            //}
        }
    }
    }
