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
    public partial class UrediRecenzijuForm : Form
    {
        string salon, opis;
        int? ocjena, idRecenzija;
        int idTermina;
        RecenzijeForm ParentForm;
        RecenzijeManager RecenzijeManager = new RecenzijeManager();
        public UrediRecenzijuForm(RecenzijeForm parent, string nazivSalona, int? Ocjena, int idtermin, string Opis, int?idrecenzija)
        {
            InitializeComponent();
            salon = nazivSalona;
            ocjena = Ocjena;
            idTermina = idtermin;
            opis = Opis;
            idRecenzija = idrecenzija;
            ParentForm = parent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UrediRecenzijuForm_FormClosing);
        }
        private void UrediRecenzijuForm_FormClosing(object sender, EventArgs e)
        {
            ParentForm.osvjezi();
        }

        private void UrediRecenzijuForm_Load(object sender, EventArgs e)
        {
            textBoxSalon.Text = salon;
            if (ocjena != null)
            {
                numericUpDownOcjena.Value = decimal.Parse(ocjena.ToString());
            }
            textBoxOpis.Text = opis;
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonUredi_Click(object sender, EventArgs e)
        {
            SaloniManager saloni = new SaloniManager();
            if (saloni.ProvjeraPodataka(textBoxOpis.Text))
            {
                RecenzijeManager.UnesiRecenziju(textBoxOpis.Text, int.Parse(numericUpDownOcjena.Value.ToString()), 
                    idTermina, idRecenzija);
                
                Close();
            }
            else
            {
                MessageBox.Show("U opisu se ne smije nalaziti znakovi <, >, ', i " + '"');
            }
        }
    }
}
