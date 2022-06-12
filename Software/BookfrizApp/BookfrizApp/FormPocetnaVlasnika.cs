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
        public FormPocetnaVlasnika(FormPrijava forma, Vlasnik dohvaceniVlasnik)
        {
            InitializeComponent();
            forma.Hide();
            vlasnik = dohvaceniVlasnik;

            Salon salon = baza.DohvatiSalon(vlasnik.idSalon);

            lblNazivSalona.Text = salon.Naziv;
        }
    }
}
