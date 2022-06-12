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

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.ShowDialog();
        }
    }
}
