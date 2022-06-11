﻿using System;
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
    public partial class NaručivanjeForm : Form
    {
        SaloniManager saloni = new SaloniManager();
        string salon, usluga;
        DateTime datum;
        int vrijeme;
        public NaručivanjeForm()
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
            PopisTermina termin = dataGridViewSaloniUsluge.CurrentRow.DataBoundItem as PopisTermina;
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
            
            vrijeme = int.Parse(numericUpDownSati.Value.ToString());
            if (!saloni.ProvjeriIspravnostDatuma(dateTimePicker.Value))
            {
                MessageBox.Show("Molim da ne tražite termine u prošlosti.");
            }
            else
            {
                datum = dateTimePicker.Value;
                dataGridViewSaloniUsluge.DataSource = saloni.DohvatiTermine(salon, usluga, vrijeme, datum, vrijeme);
                dataGridViewSaloniUsluge.Columns[0].Visible = false;
            }
            
        }
    }
}
