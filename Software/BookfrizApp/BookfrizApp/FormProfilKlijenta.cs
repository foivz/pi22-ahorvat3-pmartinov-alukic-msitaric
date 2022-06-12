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
        /*public FormProfilKlijenta(Klijent prijavljeniKlijent)
        {
            InitializeComponent();
            klijent = prijavljeniKlijent;
            klijent = new Klijent
            {
                Ime = "Kornelija",
                Prezime = "Petunija",
                Email = "kornelija@foi.hr",
                Spol = "ženski",
                BrojTelefona = "0987654321",
                Username = "kor123",
                Lozinka = "petunija123"
            };
            PrikaziPodatke();
        }*/

        //za testiranje
        public FormProfilKlijenta()
        {
            InitializeComponent();
            klijent = new Klijent
            {
                Ime = "Kornelija",
                Prezime = "Petunija",
                Email = "kornelija@foi.hr",
                Spol = "ženski",
                BrojTelefona = "0987654321",
                Username = "kor123",
                Lozinka = "petunija123"
            };
            PrikaziPodatke();
        }


        private void PrikaziPodatke()
        {
            txtIme.Text = klijent.Ime;
            txtPrezime.Text = klijent.Prezime;
            txtEmail.Text = klijent.Email;
            comboSpol.Text = klijent.Spol;
            txtBrojTelefona.Text = klijent.BrojTelefona;
            txtKorisnickoIme.Text = klijent.Username;
        }

        private void btnPromjeniLozinku_Click(object sender, EventArgs e)
        {
            FormPromjenaLozinke forma = new FormPromjenaLozinke(klijent);
            forma.ShowDialog();
            PrikaziPodatke();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var con = new PI2230_DBEntities())
            {

            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
