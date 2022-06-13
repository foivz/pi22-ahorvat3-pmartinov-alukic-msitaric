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
    public partial class FormProfilKlijenta : Form
    {
        Klijent klijent = new Klijent();
        Baza baza = new Baza();
        public FormProfilKlijenta(Klijent prijavljeniKlijent)
        {
            InitializeComponent();
            klijent = prijavljeniKlijent;
            PrikaziPodatke(klijent);
        }

        private void PrikaziPodatke(Klijent prikaziKlijent)
        {
            Klijent klijent = prikaziKlijent;
            txtIme.Text = klijent.Ime;
            txtPrezime.Text = klijent.Prezime;
            txtEmail.Text = klijent.Email;
            txtSpol.Text = klijent.Spol;
            txtBrojTelefona.Text = klijent.BrojTelefona;
            txtKorisnickoIme.Text = klijent.Username;
        }

        private void btnPromjeniLozinku_Click(object sender, EventArgs e)
        {
            FormPromjenaLozinke forma = new FormPromjenaLozinke(klijent);
            forma.ShowDialog();
            PrikaziPodatke(klijent);
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            Klijent azuriraniKlijent = new Klijent();

            azuriraniKlijent.idKlijent = klijent.idKlijent;
            azuriraniKlijent.Ime = txtIme.Text;
            azuriraniKlijent.Prezime = txtPrezime.Text;
            azuriraniKlijent.Email = txtEmail.Text;
            azuriraniKlijent.BrojTelefona = txtBrojTelefona.Text;
            azuriraniKlijent.Username = txtKorisnickoIme.Text;
            azuriraniKlijent.Spol = txtSpol.Text;

            baza.AzurirajKlijenta(klijent,azuriraniKlijent);
            MessageBox.Show("Podatci su uspješno spremljeni!");

            PrikaziPodatke(azuriraniKlijent);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
