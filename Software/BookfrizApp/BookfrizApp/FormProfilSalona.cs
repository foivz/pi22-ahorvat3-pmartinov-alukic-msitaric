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
    public partial class FormProfilSalona : Form
    {
        Salon salon = new Salon();
        Baza baza = new Baza();

        public FormProfilSalona(Salon selektiraniSalon)
        {
            InitializeComponent();
            salon = selektiraniSalon;
            PrikaziPodatke(salon);
        }
        public void PrikaziPodatke(Salon selektiraniSalon)
        {
            salon = selektiraniSalon;
            txtAdresaSalona.Text = salon.Adresa;
            txtBrojTelefona.Text = salon.BrojTelefona;
            txtEmail.Text = salon.Email;
            txtNazivSalona.Text = salon.Naziv;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {          
            Salon azuriraniSalon = new Salon();

            azuriraniSalon.Naziv = txtNazivSalona.Text;
            azuriraniSalon.Adresa = txtAdresaSalona.Text;
            azuriraniSalon.BrojTelefona = txtBrojTelefona.Text;
            azuriraniSalon.Email = txtEmail.Text;

            baza.AzurirajSalon(azuriraniSalon);
            MessageBox.Show("Podatci su uspješno spremljeni!");

            PrikaziPodatke(azuriraniSalon);
        }

        private void Odustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
