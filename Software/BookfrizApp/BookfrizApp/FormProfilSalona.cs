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
        public FormProfilSalona()
        {
            InitializeComponent();
            salon.idSalon = 22;
            salon.Naziv = "Albina";
            salon.Adresa = "Adresa 123";
            salon.BrojTelefona = "123456";
            salon.Email = "albina@gmail.com";
            salon.idGrad = 1;
            salon.Ocjena = 3;
            PrikaziPodatke();
        }
        /*public FormProfilSalona(Salon selektiraniSalon)
        {
            InitializeComponent();
            salon = selektiraniSalon;
        }*/
        public void PrikaziPodatke()
        {
            txtAdresaSalona.Text = salon.Adresa;
            txtBrojTelefona.Text = salon.BrojTelefona;
            txtEmail.Text = salon.Email;
            txtNazivSalona.Text = salon.Naziv;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var con = new PI2230_DBEntities())
            {
                con.Salons.Attach(salon);

                salon.Email = txtEmail.Text;
                salon.Adresa = txtAdresaSalona.Text;
                salon.Naziv = txtNazivSalona.Text;
                salon.BrojTelefona = txtBrojTelefona.Text;

                con.SaveChanges();
                MessageBox.Show("Podatci o salonu su uspješno ažurirani!");
            }
        }

        private void Odustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
