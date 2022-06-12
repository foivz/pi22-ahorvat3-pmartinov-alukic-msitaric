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
    public partial class FormPrijava : Form
    {
        Baza baza = new Baza();
        public FormPrijava()
        {
            InitializeComponent();
            lblRegistracija.Visible = false;
            btnRegistracija.Visible = false;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtKorisnickoIme.Text;
            string lozinka = txtLozinka.Text;

            if (baza.ProvjeriPostojiKlijent(korisnickoIme, lozinka))
            {
                MessageBox.Show("Uspješna prijava!");
                Klijent klijent = baza.DohvatiKlijenta(korisnickoIme, lozinka);
                //otvaranje početne forme za klijenta
                
            } else if (baza.ProvjeriPostojiVlasnik(korisnickoIme, lozinka))
            {
                MessageBox.Show("Uspješna prijava!");
                Vlasnik vlasnik = baza.DohvatiVlasnika(korisnickoIme, lozinka);
                //otvaranje početne forme za vlasnika

            } else
            {
                MessageBox.Show("Neuspješna prijava!");
                lblRegistracija.Visible = true;
                btnRegistracija.Visible = true;
            }
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            // otvarnje forme za registraciju
        }
    }
}
