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
    public partial class DodajNovuAkcijuForm : Form
    {
        MojeAkcijeManager MojeAkcijeManager = new MojeAkcijeManager();
        MojeAkcijeForm ParentForm;
        int idSalona;
        public DodajNovuAkcijuForm(MojeAkcijeForm parent, int idsalona)
        {
            InitializeComponent();
            idSalona = idsalona;
            ParentForm = parent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DodajNovuAkcijuForm_FormClosing);
        }
        private void DodajNovuAkcijuForm_FormClosing(object sender, EventArgs e)
        {
            ParentForm.osvjezi();
        }

        private void DodajNovuAkcijuForm_Load(object sender, EventArgs e)
        {
            comboBoxUsluga.DataSource = MojeAkcijeManager.DohvatiUslugeSalona(2);
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDodajAkciju_Click(object sender, EventArgs e)
        {
            SaloniManager saloniManager = new SaloniManager();
            if (saloniManager.ProvjeraPodataka(textBoxOpis.Text))
            {
                string opis = textBoxOpis.Text;
                DateTime datumIsteka = dateTimePickerDatumIsteka.Value;
                decimal novaCijena = numericUpDownCijena.Value;
                Usluga usluga = comboBoxUsluga.SelectedItem as Usluga;
                MojeAkcijeManager.UnesiAkciju(opis, datumIsteka, novaCijena, usluga, idSalona);
                MessageBox.Show("Uspješno unesena akcija salona");
                Close();
            }
            else
            {
                MessageBox.Show("Polje 'Opis' ne smije sadržavati znakove <, >, ', i " + '"' + " !");
            }
        }
    }
}
