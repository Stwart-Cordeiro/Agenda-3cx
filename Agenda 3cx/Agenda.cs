using System;
using System.Data;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Agenda_3cx
{
    public partial class Agenda : Form
    {
        private OdbcConnection conn;
        private OdbcDataAdapter da;
        private DataSet ds;
        private int Linhaatual;

        private string nome, telefone, codigo, Ramal;

        public Agenda()
        {
            InitializeComponent();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            iniciaAcesso();
        }

        private void iniciaAcesso()
        {
            ds = new DataSet();
            conn = new OdbcConnection("Dsn=PostgreSQL40W");
            try
            {
                conn.Open();
            }
            catch (SystemException erro)
            {
                MessageBox.Show(erro.Message.ToString());
            }
            if (conn.State == ConnectionState.Open)
            {
                da = new OdbcDataAdapter("Select * from agenda ORDER BY id_cadastro", conn);
                da.Fill(ds, "Tabela");
                DGVInicio.DataSource = ds;
                DGVInicio.DataMember = "Tabela";
            }

        }

        #region "OBTEM DADOS GRID"

        private void obtemDadosGrid()
        {
            nome = DGVInicio[1, Linhaatual].Value.ToString();
            telefone = DGVInicio[2, Linhaatual].Value.ToString();

        }

        private void DGVInicio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Linhaatual = int.Parse(e.RowIndex.ToString());
        }
       
        #endregion

        private void carregaGrid(string criterioSQL)
        {
            ds = new DataSet();

            conn = new OdbcConnection("Dsn=PostgreSQL40W");

            try
            {
                conn.Open();
            }
            catch (SystemException err)
            {
                MessageBox.Show("Erro" + err.Message);
            }
            if (conn.State == ConnectionState.Open)
            {
                da = new OdbcDataAdapter(criterioSQL, conn);
                da.Fill(ds, "Tabela");
                DGVInicio.DataSource = ds;
                DGVInicio.DataMember = "Tabela";
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Frm_Insert insert = new Frm_Insert();

            insert.ShowDialog();
            DGVInicio.Update();
            iniciaAcesso();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                codigo = DGVInicio[0, Linhaatual].Value.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro" + err.Message);
            }
            if (Linhaatual >= 0)
            {
                obtemDadosGrid();

                Frm_Alterar altera = new Frm_Alterar();
                altera.codigo = codigo;
                altera.nome = nome;
                altera.telefone = telefone;

                altera.ShowDialog();

                DGVInicio.Update();
                iniciaAcesso();
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                codigo = DGVInicio[0, Linhaatual].Value.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro" + err.Message);
            }
            if (Linhaatual >= 0)
            {
                obtemDadosGrid();

                Frm_Excluir excluir = new Frm_Excluir();

                excluir.codigo = codigo;
                excluir.nome = nome;
                excluir.telefone = telefone;

                excluir.ShowDialog();

                DGVInicio.Update();

                iniciaAcesso();
            }

        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Frm_Pesquisa pesquisa = new Frm_Pesquisa();

            pesquisa.ShowDialog();

            if (pesquisa.sqlstring != null && pesquisa.sqlstring != "")
            {
                carregaGrid(pesquisa.sqlstring);
            }

        }

        private Boolean validadados()
        {
            if (txtRamal.Text == string.Empty)
                return false;
            return true;
        }

        private void btnDiscar_Click(object sender, EventArgs e)
        {
            if (validadados())
            {
                
                try
                {
                    telefone = DGVInicio[2, Linhaatual].Value.ToString();
                    Ramal = txtRamal.Text;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro" + erro.Message);
                }
                if (Linhaatual >= 0)
                {
                    obtemDadosGrid();

                   Frm_Ramal ramal = new Frm_Ramal();

                    ramal.ramal = Ramal;
                    ramal.telefone = telefone;

                    ramal.ShowDialog();

                    iniciaAcesso();
                }
            }
            else
            {
                MessageBox.Show("Digite o seu ramal");
                txtRamal.Focus();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
