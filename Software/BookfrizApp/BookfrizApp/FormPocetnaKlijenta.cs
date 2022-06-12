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
using BookfrizApp.Forms;

namespace BookfrizApp
{
    public partial class FormPocetnaKlijenta : Form
    {
        Klijent klijent = new Klijent();
        public FormPocetnaKlijenta(FormPrijava forma, Klijent dohvaceniKlijent)
        {
            InitializeComponent();
            forma.Hide();
            klijent = dohvaceniKlijent;
            lblImeKlijenta.Text = klijent.Ime;
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.ShowDialog();
        }

        private void btnTrazilica_Click(object sender, EventArgs e)
        {
            Trazilica trazilica = new Trazilica();
            trazilica.ShowDialog();
        }

        private void btnPopisSalona_Click(object sender, EventArgs e)
        {
            SaloniUBlizini saloniUBlizini = new SaloniUBlizini();
            saloniUBlizini.ShowDialog();
        }
    }
}
