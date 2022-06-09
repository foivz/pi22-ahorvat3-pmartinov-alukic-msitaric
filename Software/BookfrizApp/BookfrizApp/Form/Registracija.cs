using BookfrizApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registracija_novo
{
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }
        Repozitorij repozitorij = new Repozitorij();
        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            string spol;
            if (radioMusko.Checked) spol = "musko";
            else if (radioZensko.Checked) spol = "zensko";
            else spol = null;
            Korisnik korisnik = new Korisnik(txtIme.Text, txtPrezime.Text, spol, txtBroj.Text, txtEmail.Text, txtLozinka.Text);
            repozitorij.korisnik = korisnik;
            repozitorij.KreiranjeUserName();
            if (repozitorij.ProvjeriPostojanje(txtEmail.Text)) throw new Exception();
            else if (ProvjeraSigurnosti()) throw new Exception();
            else if (ProvjeraIspravnostiPodataka()) throw new Exception();
            else
            {
                repozitorij.DodajUBazu();
                MessageBox.Show("Uspješno ste se registrirali!\n Vaš Username je " + repozitorij.korisnik.User + ". Možete ga provjeriti u osobnim podacima.", "Uspješna registracija");
                Close();
            }
        }
        private bool ProvjeraSigurnosti()
        {
            string loznika = txtLozinka.Text;
            if (Regex.IsMatch(loznika, "[A-Z]") && Regex.IsMatch(loznika, "[0-9]") && loznika.Length >= 6) return true;
            return false;
        }
        private bool ProvjeraIspravnostiPodataka()
        {
            if (txtLozinka.Text != txtPonovljena.Text) return true;
            return false;
        }

        private void Registracija_Load_1(object sender, EventArgs e)
        {
            btnPrikazLozinka.BringToFront();
            btnPrikazPonovljena.BringToFront();
        }

        private void btnPrikazLozinka_Click(object sender, EventArgs e)
        {
            btnSakrijLozinka.BringToFront();
            txtLozinka.PasswordChar = '\0';
        }

        private void btnSakrijLozinka_Click(object sender, EventArgs e)
        {
            btnPrikazLozinka.BringToFront();
            txtLozinka.PasswordChar = '*';
        }

        private void btnPrikazPonovljena_Click(object sender, EventArgs e)
        {
            btnSakrijPonovljena.BringToFront();
            txtPonovljena.PasswordChar = '\0';
        }

        private void btnSakrijPonovljena_Click(object sender, EventArgs e)
        {
            btnPrikazPonovljena.BringToFront();
            txtPonovljena.PasswordChar = '*';
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
