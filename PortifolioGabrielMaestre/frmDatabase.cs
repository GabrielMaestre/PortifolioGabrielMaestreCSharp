using System;
using System.Windows.Forms;

//using MySql.Data;
using MySql.Data.MySqlClient;

namespace PortifolioGabrielMaestre
{
    public partial class frmDatabase : Form
    {
        public frmDatabase()
        {
            InitializeComponent();
        }

        MySqlConnection objCon = new MySqlConnection("server=localhost;port=3306;uid=xx;database=xx;password=xx");
        string login, password;

        private void frmDadabase_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidaUsuario(txtEmail.Text, txtPassword.Text))
            {
                this.DialogResult = DialogResult.OK;

                //frmSistemaBanco fSistemaBanco = new frmSistemaBanco();
                //fSistemaBanco.ShowDialog($"{txtEmail.Text}");
                //this.Hide();

                MessageBox.Show("Usuário Válido!");
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                MessageBox.Show("Usuário Inválido!");
            }
        }

        private bool ValidaUsuario(string email, string senha)
        {
            //variável que será testada para
            //informar o retorno
            int retorno = -1;

            //comando sql que dá um count 
            //na tabela se existirem usuario e senha
            //com os dados informados
            string comando = "SELECT COUNT(*) FROM login WHERE email=@Email AND password=@Senha";

            //instância do comando
            MySqlCommand cmd = new MySqlCommand(comando, objCon);

            //preenchimento dos parâmetros
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Senha", senha);

            //abro conexão
            objCon.Open();
            //retorno recebe o resultado do execute scalar
            retorno = Convert.ToInt32(cmd.ExecuteScalar());

            //fecho conexão
            objCon.Close();

            //retorno true se retorno for maior que zero
            return retorno > 0;

        }
    }
}
