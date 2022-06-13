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
    public partial class FormPromjenaLozinke : Form
    {
        Klijent klijent = new Klijent();
        Baza baza = new Baza();
        public FormPromjenaLozinke(Klijent prijavljeniKlijent)
        {
            InitializeComponent();
            klijent = prijavljeniKlijent;
            txtNovaLozinka.UseSystemPasswordChar = true;
            txtStaraLozinka.UseSystemPasswordChar = true;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            Klijent dohvaceniKlijent = baza.DohvatiKlijenta(klijent.Username, klijent.Lozinka);
            if (txtNovaLozinka.Text.Length == 0 || txtNovaLozinka.Text.Length == 0)
            {
                MessageBox.Show("Popunite oba polja!");
                return;
            }
            else
            {
                if (dohvaceniKlijent.Lozinka != txtStaraLozinka.Text)
                {
                    MessageBox.Show("Stara lozinka nije točna!");
                    return;
                }
                if (txtNovaLozinka.Text == txtStaraLozinka.Text)
                {
                    MessageBox.Show("Nova lozinka ne može biti stara lozinka!");
                    return;
                }
                if (txtNovaLozinka.Text != txtStaraLozinka.Text)
                {
                    baza.AzurirajLozinku(dohvaceniKlijent, txtNovaLozinka.Text);
                    MessageBox.Show("Lozinka je uspješno spremljena!");
                }
            }
            
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrikaziStaru_Click(object sender, EventArgs e)
        {
            txtStaraLozinka.UseSystemPasswordChar = false;
        }

        private void btnPrikaziNovu_Click(object sender, EventArgs e)
        {
            txtNovaLozinka.UseSystemPasswordChar = false;
        }
    }
}
