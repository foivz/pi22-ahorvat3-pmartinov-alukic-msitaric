using System;
using System.Windows.Forms;
using BookfrizApp.Classes;
using BazaPodataka;

namespace BookfrizApp.Forms
{
    public partial class Cjenik : Form
    {
        private Salon Salon = new Salon();
        private string Usluga;
        private int CijenaOd, CijenaDo;
        private TrazilicaIspis trazilicaIspis;
        private Klijent Klijent;
        public Cjenik(Salon salon,string usluga,int cijenaOd,int cijenaDo,TrazilicaIspis trazilica, Klijent klijent)
        {
            Salon = salon;
            Usluga = usluga;
            CijenaOd = cijenaOd;
            CijenaDo = cijenaDo;
            trazilicaIspis = trazilica;
            trazilicaIspis.Hide();
            Klijent = klijent;
            InitializeComponent();
        }
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
            trazilicaIspis.Show();
        }

        private void btnRezervacija_Click(object sender, EventArgs e)
        {
            NarucivanjeForm narucivanjeForm = new NarucivanjeForm(Klijent.idKlijent, Usluga, Salon.Naziv);
            Console.WriteLine(Usluga);
            Hide();
            narucivanjeForm.ShowDialog();
            
        }

        private void Cjenik_Load(object sender, EventArgs e)
        {
            Repozitorij repozitorij = new Repozitorij();
            dgvCjenik.DataSource = repozitorij.PrikaziZeljeneUslugeSalona(Salon, Usluga, CijenaOd, CijenaDo);
            dgvCjenik.Columns["Cjeniks"].Visible = false;
            dgvCjenik.Columns["idUsluga"].Visible = false;
        }
        
    }
}
