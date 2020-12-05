using System;
using System.Windows.Forms;

namespace Agenda_3cx
{
    public partial class Frm_Ramal : Form
    {
        public string telefone, ramal;
        public string url;

        public Frm_Ramal()
        {
            InitializeComponent();
            txtRamal.ReadOnly = true;
            txtTelefone.ReadOnly = true;
        }

        private void Frm_Ramal_Load(object sender, EventArgs e)
        {
            txtTelefone.Text = telefone;
            txtRamal.Text = ramal;
            System.Diagnostics.Process.Start(@"C:\ProgramData\3CXPhone for Windows\PhoneApp\3CXWin8Phone.exe");

            url = "192.168.1.7:5000/ivr/PbxAPI.aspx?func=make_call&from=" + txtRamal.Text + "&to=" + txtTelefone.Text + "&pin=dig" + txtRamal.Text + "";
            linkLabel1.Text = "Para Discar  CLICK AQUI";
            linkLabel1.Links.Add(13, 10, "Http://" + url + "");           
        }

        //private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        //    this.Close();
        //}

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
