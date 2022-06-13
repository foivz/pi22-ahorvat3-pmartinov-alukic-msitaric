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
    public partial class MojeAkcijeForm : Form
    {
        MojeAkcijeManager MojeAkcijeManager = new MojeAkcijeManager();
        public MojeAkcijeForm()
        {
            InitializeComponent();
        }

        private void MojeAkcijeForm_Load(object sender, EventArgs e)
        {
            osvjezi();
        }

        public void osvjezi()
        {
            //tu treba dodati da se prosljeđuje ime salona vlasnika/id
            dataGridViewMojeAkcije.DataSource = MojeAkcijeManager.DohvatiKlijentAkcije("Zdena");
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
            DodajNovuAkcijuForm dodajNovuAkcijuForm = new DodajNovuAkcijuForm(this, 2);
            //Ovdje treba prosljediti ime salona vlasnika/id
            dodajNovuAkcijuForm.Show();
        }
    }
}
