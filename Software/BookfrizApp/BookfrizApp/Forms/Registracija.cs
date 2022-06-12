using BookfrizApp.Classes;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BookfrizApp.Exceptions;

namespace BookfrizApp.Forms
{
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }
        private Repozitorij repozitorij = new Repozitorij();
        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            string spol;
            if (radioMusko.Checked) spol = "musko";
            else if (radioZensko.Checked) spol = "zensko";
            else spol = null;
            Korisnik korisnik = new Korisnik(txtIme.Text, txtPrezime.Text, spol, txtBroj.Text, txtEmail.Text, txtLozinka.Text);
            repozitorij.korisnik = korisnik;
            try
            {
                if (txtIme.Text == "" || txtPrezime.Text == "" || txtEmail.Text == "" || txtBroj.Text == "" || txtLozinka.Text == "" || txtPonovljena.Text == "") throw new UnosException("Molimo unesite sve podatke!");
                repozitorij.KreiranjeUserName();
                repozitorij.ProvjeriPostojanje(txtEmail.Text);
                ProvjeraSigurnosti();
                ProvjeraIspravnostiPodataka();
                repozitorij.DodajUBazu();
                MessageBox.Show("Uspješno ste se registrirali!\n Vaš Username je " + repozitorij.korisnik.User + ". Možete ga provjeriti u osobnim podacima.", "Uspješna registracija");
                Close();
            }
            catch (UnosException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
            catch (PostojanjeException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
            catch (SigurnostException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
            catch (IspravnostException ex)
            {
                MessageBox.Show(ex.Poruka);
            }

        }
        private bool ProvjeraSigurnosti()
        {
            string loznika = txtLozinka.Text;
            if (Regex.IsMatch(loznika, "[a-zA-Z]") && Regex.IsMatch(loznika,"[0-9]") && loznika.Length >= 6) return true;
            throw new SigurnostException("Lozinka treba sadržavati 6 znakova uključujući brojeve i slova!");
        }
        private bool ProvjeraIspravnostiPodataka()
        {
            if (txtLozinka.Text != txtPonovljena.Text) throw new IspravnostException("Lozinke se ne poklapaju!");
            return true;
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
