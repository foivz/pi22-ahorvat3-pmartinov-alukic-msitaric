using System;
using System.Windows.Forms;
using BookfrizApp.Classes;

namespace BookfrizApp.Forms
{
    public partial class Cjenik : Form
    {
        private Salon Salon = new Salon();
        private Usluga Usluga = new Usluga();
        private int CijenaOd, CijenaDo;
        public Cjenik(Salon salon,Usluga usluga,int cijenaOd,int cijenaDo)
        {
            Salon = salon;
            Usluga = usluga;
            CijenaOd = cijenaOd;
            CijenaDo = cijenaDo;
            InitializeComponent();
        }
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRezervacija_Click(object sender, EventArgs e)
        {
            //odvedinarezervaciju
        }

        private void Cjenik_Load(object sender, EventArgs e)
        {
            Repozitorij repozitorij = new Repozitorij();
            dgvCjenik.DataSource = repozitorij.PrikaziZeljeneUslugeSalona(Salon, Usluga, CijenaOd, CijenaDo);
            dgvCjenik.Columns["Cjenik"].Visible = false;
            dgvCjenik.Columns["idUsluga"].Visible = false;
        }
        
    }
}
