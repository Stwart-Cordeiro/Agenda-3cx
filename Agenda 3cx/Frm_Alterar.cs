using System;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Agenda_3cx
{
    public partial class Frm_Alterar : Form
    {
        public string nome, telefone, codigo;

        public Frm_Alterar()
        {
            InitializeComponent();
        }

        private void Frm_Alterar_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = codigo;
            txtNome.Text = nome;
            txtTelefone.Text = telefone;
        }

        #region "Altera Dados"

        private void Alteradados()
        {
            string strconnection = "Dsn=PostgreSQL40W";

            string strsql = "UPDATE agenda SET nome= '" + txtNome.Text.Replace("'", "''") + "', telefone= '" + txtTelefone.Text + "' WHERE id_cadastro = " + int.Parse(codigo) + "";

            OdbcConnection dbconnection = new OdbcConnection(strconnection);

            OdbcCommand cmdaltera = new OdbcCommand(strsql, dbconnection);

            try
            {
                dbconnection.Open();

                cmdaltera.ExecuteNonQuery();

                if (MessageBox.Show("Dados Alterados com Sucesso", "Alterado", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch (OdbcException sqlerr)
            {
                MessageBox.Show("Erro" + sqlerr.Message);
            }
            finally
            {
                dbconnection.Close();
            }

        }

        private Boolean validadados()
        {
            if (txtNome.Text == string.Empty)
                return false;
            if (txtTelefone.Text == string.Empty)
                return false;

            return true;
        }

        #endregion

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (validadados())
            {
                Alteradados();
            }
            else
            {
                MessageBox.Show("Dados Invalidos...");
                txtNome.Focus();
            }
            return;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
