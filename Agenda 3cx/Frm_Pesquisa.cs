using System;
using System.Windows.Forms;

namespace Agenda_3cx
{
    public partial class Frm_Pesquisa : Form
    {
        private string criterio = "";
        public string sqlstring = "";

        public Frm_Pesquisa()
        {
            InitializeComponent();
        }

        private void Frm_Pesquisa_Load(object sender, EventArgs e)
        {
            txtPesquisa.Focus();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            criterio = txtPesquisa.Text.ToString();

            if (criterio != "")
            {
                sqlstring = "select * from agenda where nome like '" + criterio + "%'";
                this.Close();
            }
            else
            {
                MessageBox.Show("Informe o Nome a procura com Pelo Menos um Caracter.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPesquisa.Focus();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
