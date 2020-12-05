using System;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Agenda_3cx
{
    public partial class Frm_Insert : Form
    {
        public Frm_Insert()
        {
            InitializeComponent();
        }

        private void Frm_Insert_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
        }

        private void Salvadados()
        {
            string strconnection = "Dsn=PostgreSQL40W";

            string strsql = "INSERT INTO agenda(nome, telefone) VALUES ('" + txtNome.Text + "'," + txtTelefone.Text + ");";

            OdbcConnection dbconnection = new OdbcConnection(strconnection);

            OdbcCommand cmdIncluir = new OdbcCommand(strsql, dbconnection);

            try
            {
                dbconnection.Open();

                cmdIncluir.ExecuteNonQuery();

                if (MessageBox.Show("Dados salvos com Sucesso. deseja cadastrar um novo", "Salvo", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    this.Close();
                }
                else
                {
                    Limpacamposformulario(this.Controls);
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

        private Boolean Validadados()
        {
            if (txtNome.Text == string.Empty)
                return false;
            if (txtTelefone.Text == string.Empty)
                return false;

            return true;
        }

        private void Limpacamposformulario(Control.ControlCollection controles)
        {
            foreach (Control ctr in controles)
            {
                if (ctr is TextBox)
                {
                    ((TextBox)(ctr)).Clear();
                }
                Limpacamposformulario(ctr.Controls);
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (Validadados())
            {
                Salvadados();
            }
            else
            {
                MessageBox.Show("Dados Invalidos...");
                txtNome.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpacamposformulario(this.Controls);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
