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

        private void btnProfilKorisnika_Click(object sender, EventArgs e)
        {
            FormProfilKlijenta forma = new FormProfilKlijenta(klijent);
            forma.ShowDialog();
        }

        private void btnObavijesti_Click(object sender, EventArgs e)
        {
            FormObavijestiKlijenta forma = new FormObavijestiKlijenta(klijent);
            forma.ShowDialog();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.ShowDialog();
        }

        private void btnTrazilica_Click(object sender, EventArgs e)
        {
            Trazilica trazilica = new Trazilica(klijent);
            trazilica.ShowDialog();
        }

        private void btnPopisSalona_Click(object sender, EventArgs e)
        {
            SaloniUBlizini saloniUBlizini = new SaloniUBlizini();
            saloniUBlizini.ShowDialog();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            FormProfilKlijenta forma = new FormProfilKlijenta(klijent);
            forma.ShowDialog();
        }

        private void btnObavijesti_Click_1(object sender, EventArgs e)
        {
            FormObavijestiKlijenta forma = new FormObavijestiKlijenta(klijent);
            forma.ShowDialog();
        }

        private void buttonPopisAkcija_Click(object sender, EventArgs e)
        {
            AkcijeForm akcijeForm = new AkcijeForm();
            akcijeForm.ShowDialog();
        }

        private void buttonNarucivanje_Click(object sender, EventArgs e)
        {
            NarucivanjeForm naručivanjeForm = new NarucivanjeForm(klijent.idKlijent, "Svi saloni", "Sve usluge");
            naručivanjeForm.ShowDialog();
        }

        private void buttonMojeRecenzije_Click(object sender, EventArgs e)
        {
            RecenzijeForm recenzijeForm = new RecenzijeForm(klijent.idKlijent);
            recenzijeForm.ShowDialog();
        }
    }
}
