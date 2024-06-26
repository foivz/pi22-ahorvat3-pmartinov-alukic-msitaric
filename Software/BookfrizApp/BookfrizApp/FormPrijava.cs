﻿using System;
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
    public partial class FormPrijava : Form
    {
        Baza baza = new Baza();
        public FormPrijava()
        {
            InitializeComponent();
            lblRegistracija.Visible = false;
            btnRegistracija.Visible = false;
            txtLozinka.UseSystemPasswordChar = true;
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
                Klijent klijent= baza.DohvatiKlijenta(korisnickoIme, lozinka);
                //otvaranje početne forme za klijenta
                FormPocetnaKlijenta forma = new FormPocetnaKlijenta(this,klijent);
                forma.ShowDialog();
                Close();
                
            } else if (baza.ProvjeriPostojiVlasnik(korisnickoIme, lozinka))
            {
                MessageBox.Show("Uspješna prijava!");
                Vlasnik vlasnik = baza.DohvatiVlasnika(korisnickoIme, lozinka);
                //otvaranje početne forme za vlasnika
                FormPocetnaVlasnika forma = new FormPocetnaVlasnika(this,vlasnik);
                forma.ShowDialog();
                Close();

            } else
            {
                MessageBox.Show("Neuspješna prijava!");
                lblRegistracija.Visible = true;
                btnRegistracija.Visible = true;
            }
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.ShowDialog();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            txtLozinka.UseSystemPasswordChar = false;
        }
    }
}
