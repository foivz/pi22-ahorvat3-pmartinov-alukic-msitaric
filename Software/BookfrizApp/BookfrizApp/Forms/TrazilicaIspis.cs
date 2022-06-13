using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BazaPodataka;

namespace BookfrizApp.Forms
{
    public partial class TrazilicaIspis : Form
    {
        private List<Salon> Saloni = new List<Salon>();
        private string Usluga;
        private int CijenaOd, CijenaDo;
        public TrazilicaIspis(List<Salon> saloni,string usluga,int cijenaOd,int cijenaDo,Trazilica trazilica)
        {
            Saloni = saloni;
            Usluga = usluga;
            CijenaOd = cijenaOd;
            CijenaDo = cijenaDo;
            trazilica.Hide();
            InitializeComponent();
        }
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnCjenik_Click(object sender, EventArgs e)
        {
            Cjenik cjenik = new Cjenik(dgvTrazilica.CurrentRow.DataBoundItem as Salon, Usluga, CijenaOd, CijenaDo,this);
            cjenik.ShowDialog();
            Hide();
        }
        private void TrazilicaIspis_Load(object sender, EventArgs e)
        {
            dgvTrazilica.DataSource = Saloni;
            dgvTrazilica.Columns["idSalon"].Visible = false;
            dgvTrazilica.Columns["idGrad"].Visible = false;
            dgvTrazilica.Columns["Grad"].Visible = false;
            dgvTrazilica.Columns["Termins"].Visible = false;
            dgvTrazilica.Columns["Cjeniks"].Visible = false;
            dgvTrazilica.Columns["Vlasniks"].Visible = false;
        }
    }
}
