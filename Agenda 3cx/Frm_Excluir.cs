using System;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Agenda_3cx
{
    public partial class Frm_Excluir : Form
    {
        public string codigo, nome, telefone;

        public Frm_Excluir()
        {
            InitializeComponent();
        }

        private void Frm_Excluir_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = codigo;
            txtNome.Text = nome;
            txtTelefone.Text = telefone;
            btnExcluir.Focus();
        }

        #region "EXCLUINDO DADOS"

        private void excluirdados()
        {
            string strconnection = "Dsn=PostgreSQL40W";

            string strsql = "DELETE FROM agenda WHERE id_cadastro = " + int.Parse(codigo) + ";";

            OdbcConnection dbconnection = new OdbcConnection(strconnection);

            OdbcCommand cmdexcluir = new OdbcCommand(strsql, dbconnection);

            try
            {
                dbconnection.Open();

                cmdexcluir.ExecuteNonQuery();
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

        #endregion

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza que Deseja Excluir ?", "Excluir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                excluirdados();
                this.Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
