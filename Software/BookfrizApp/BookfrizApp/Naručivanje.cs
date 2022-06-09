using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using msitaric;

namespace BookfrizApp
{
    public partial class Naručivanje : Form
    {
        Saloni saloni = new Saloni();
        string salon, usluga;
        DateTime datum;
        int vrijeme;
        public Naručivanje()
        {
            InitializeComponent();
        }

        private void Naručivanje_Load(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTime.Now;
            comboBoxSaloni.DataSource = saloni.DohvatiSalone();
            comboBoxUsluge.DataSource = saloni.DohvatiUsluge();
        }

        private void buttonRezerviraj_Click(object sender, EventArgs e)
        {
            PopisTermina termin = dataGridView1.CurrentRow.DataBoundItem as PopisTermina;
            //1 zamjeniti sa id korisnika
            saloni.ObaviRezervaciju(termin, vrijeme, datum, 1);
            MessageBox.Show("Uspješno rezerviran termin!");
            osvjezi();
        }

        private void buttonFiltriraj_Click(object sender, EventArgs e)
        {
            osvjezi();
        }

        private void osvjezi()
        {
            salon = comboBoxSaloni.SelectedItem.ToString();
            usluga = comboBoxUsluge.SelectedItem.ToString();
            datum = dateTimePicker.Value;
            vrijeme = int.Parse(numericUpDownSati.Value.ToString());

            dataGridView1.DataSource = saloni.DohvatiTermine(salon, usluga, vrijeme);
        }
    }
}
