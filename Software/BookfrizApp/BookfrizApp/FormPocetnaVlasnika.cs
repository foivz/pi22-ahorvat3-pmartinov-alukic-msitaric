using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BazaPodataka;

namespace BookfrizApp
{
    public partial class FormPocetnaVlasnika : Form
    {
        Vlasnik vlasnik = new Vlasnik();
        Baza baza = new Baza();
        Salon salon;


        public FormPocetnaVlasnika(FormPrijava forma, Vlasnik dohvaceniVlasnik)
        {
            InitializeComponent();
            forma.Hide();
            vlasnik = dohvaceniVlasnik;

            salon = baza.DohvatiSalon(vlasnik.idSalon);
            lblNazivSalona.Text = salon.Naziv;
        }

        private void btnProfilSalona_Click(object sender, EventArgs e)
        {
            Salon salon = baza.DohvatiSalon(vlasnik.idSalon);
            FormProfilSalona forma = new FormProfilSalona(salon);
            forma.ShowDialog();
        }

        private void buttonPostaviAkcije_Click(object sender, EventArgs e)
        {
            MojeAkcijeForm mojeAkcijeForm = new MojeAkcijeForm(salon);
            mojeAkcijeForm.ShowDialog();
        }
    }
}
