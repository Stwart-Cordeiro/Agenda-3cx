using System;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Agenda_3cx
{
    public partial class Senha : Form
    {
        public Senha()
        {
            InitializeComponent();
        }

        private void Senha_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        bool verificarlogin()
        {
            bool result = false;
            string stringdeconexao = string.Format("Dsn=PostgreSQL40W");
            using (OdbcConnection cn = new OdbcConnection())
            {
                cn.ConnectionString = stringdeconexao;

                try
                {
                    OdbcCommand cmd = new OdbcCommand("SELECT * FROM User_agenda WHERE nome='" + txtUsuario.Text + "'AND senha='" + txtSenha.Text + "';", cn);
                    cn.Open();
                    OdbcDataReader dados = cmd.ExecuteReader();
                    result = dados.HasRows;
                }
                catch (OdbcException e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
            return result;       

        }

        public bool logado = false;

        private void btnConectar_Click(object sender, EventArgs e)
        {
            bool result = verificarlogin();

            logado = result;

            if (result)
            {
                logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario ou Senha Errado Favor Entrar em Contato Com o Administrador do Banco de Dados");
                logado = false;
            }

        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool result = verificarlogin();

                logado = result;


                if (result)
                {
                    logado = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario ou Senha Errado Favor Entra em Contado Com o Administrador do Banco de Dados");
                    logado = false;
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
