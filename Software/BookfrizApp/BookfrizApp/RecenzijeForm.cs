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
    public partial class RecenzijeForm : Form
    {
        int idKlijenta;
        RecenzijeManager RecenzijeManager = new RecenzijeManager();
        public RecenzijeForm(int idklijenta)
        {
            InitializeComponent();
            idKlijenta = idklijenta;
            buttonUrediRecenziju.Enabled = false;
        }

        private void RecenzijeForm_Load(object sender, EventArgs e)
        {
            osvjezi();
            dataGridViewRecenzije.SelectionChanged += new EventHandler(OsposobiGumb);
        }
        private void OsposobiGumb(object sender, EventArgs e)
        {
            buttonUrediRecenziju.Enabled = true;
        }
        public void osvjezi()
        {
            dataGridViewRecenzije.DataSource = RecenzijeManager.DohvatiRecenzije(idKlijenta);
            dataGridViewRecenzije.Columns[0].Visible = false;
            dataGridViewRecenzije.Columns[1].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrikazRecenzije salon = dataGridViewRecenzije.CurrentRow.DataBoundItem as PrikazRecenzije;
            UrediRecenzijuForm UrediRecenziju = new UrediRecenzijuForm(this, salon.NazivSalona, salon.Ocjena, 
                salon.idTermina, salon.Opis, salon.idRecenzija);
            UrediRecenziju.Show();
        }

        private void buttonNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
