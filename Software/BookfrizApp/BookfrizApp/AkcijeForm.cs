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
    public partial class AkcijeForm : Form
    {
        SaloniManager SaloniManager = new SaloniManager();
        AkcijeManager AkcijeManager = new AkcijeManager();
        public AkcijeForm()
        {
            InitializeComponent();
        }

        private void AkcijeForm_Load(object sender, EventArgs e)
        {
            comboBoxSaloni.DataSource = SaloniManager.DohvatiSalone();
            comboBoxUsluge.DataSource = SaloniManager.DohvatiUsluge();
            dataGridViewAkcije.DataSource = AkcijeManager.DohvatiSveAkcije();
        }

        private void buttonFiltrirajAkcije_Click(object sender, EventArgs e)
        {
            string usluga = comboBoxUsluge.SelectedItem.ToString();
            string salon = comboBoxSaloni.SelectedItem.ToString();
            dataGridViewAkcije.DataSource = AkcijeManager.DohvatiAkcije(salon, usluga);
        }
    }
}
