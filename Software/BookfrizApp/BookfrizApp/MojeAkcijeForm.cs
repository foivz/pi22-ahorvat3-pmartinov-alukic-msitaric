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
using BazaPodataka;

namespace BookfrizApp
{
    public partial class MojeAkcijeForm : Form
    {
        MojeAkcijeManager MojeAkcijeManager = new MojeAkcijeManager();
        Salon Salon;
        public MojeAkcijeForm(Salon salon)
        {
            InitializeComponent();
            Salon = salon;
        }

        private void MojeAkcijeForm_Load(object sender, EventArgs e)
        {
            osvjezi();
        }

        public void osvjezi()
        {
            dataGridViewMojeAkcije.DataSource = MojeAkcijeManager.DohvatiKlijentAkcije(Salon.Naziv);
            dataGridViewMojeAkcije.Columns[0].Visible = false;
        }

        private void buttonObrisiAkciju_Click(object sender, EventArgs e)
        {
            MojeAkcije ObrisiAkciju = dataGridViewMojeAkcije.CurrentRow.DataBoundItem as MojeAkcije;
            MojeAkcijeManager.ObrisiAkciju(ObrisiAkciju);
            osvjezi();
        }

        private void buttonDodajAkciju_Click(object sender, EventArgs e)
        {
            DodajNovuAkcijuForm dodajNovuAkcijuForm = new DodajNovuAkcijuForm(this, Salon.idSalon);
            dodajNovuAkcijuForm.Show();
        }

        private void buttonNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
