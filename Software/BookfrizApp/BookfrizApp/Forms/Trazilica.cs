using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookfrizApp.Classes;

namespace BookfrizApp.Forms
{
    public partial class Trazilica : Form
    {
        public Trazilica()
        {
            InitializeComponent();
        }
        Repozitorij repozitorij = new Repozitorij();

        private void trackCijenaOd_Scroll(object sender, EventArgs e)
        {
            txtCijenaOd.Text = trackCijenaOd.Value.ToString();
        }

        private void trackCijenaDo_Scroll(object sender, EventArgs e)
        {
            txtCijenaDo.Text= trackCijenaDo.Value.ToString();
        }

        private void Trazilica_Load_1(object sender, EventArgs e)
        {
            txtCijenaOd.Text = "0";
            txtCijenaDo.Text = "250";
            using (var db = new PI2230_DBEntities())
            {
                var query = (from g in db.Grad
                             select g).ToList();
                List<string> naziv = new List<string>();
                foreach (var i in query)
                {
                    naziv.Add(i.Naziv);
                }
                cmbGrad.DataSource = naziv;
                var queryy = (from u in db.Usluga
                              select u).ToList();
                List<string> nazivv = new List<string>();
                foreach (var i in queryy)
                {
                    nazivv.Add(i.Naziv);
                }
                cmbUsluga.DataSource = nazivv;
            }
        }

        private void btnOdustani_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTrazi_Click_1(object sender, EventArgs e)
        {
            Grad grad = new Grad();
            using (var db = new PI2230_DBEntities())
            {
                var query = (from g in db.Grad
                             where g.Naziv == cmbGrad.SelectedItem.ToString()
                             select g).ToList();
                grad = query[0];
            }
            string naziv = cmbUsluga.SelectedItem.ToString();
            Usluga usluga = new Usluga();
            using (var db = new PI2230_DBEntities())
            {
                var query = (from u in db.Usluga
                             where u.Naziv == naziv
                             select u).ToList();
                usluga = query[0];
            }
            double x = Convert.ToDouble(txtOcjena.Text);
            List<Salon> saloni= repozitorij.DohvatiPodatke(grad, (float)x, usluga, trackCijenaOd.Value, trackCijenaDo.Value);
            int a = 0;
        }
    }
}
