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
        private Repozitorij repozitorij = new Repozitorij();
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
                foreach (var i in query)
                {
                    cmbGrad.Items.Add(i.Naziv);
                }
                var queryy = (from u in db.Usluga
                              select u).ToList();
                foreach (var i in queryy)
                {
                    cmbUsluga.Items.Add(i.Naziv);
                }
            }
        }

        private void btnOdustani_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTrazi_Click_1(object sender, EventArgs e)
        {
            Grad grad = new Grad();
            Usluga usluga = new Usluga();
            try
            {
                using (var db = new PI2230_DBEntities())
                {
                    var query = (from g in db.Grad
                                 where g.Naziv == cmbGrad.SelectedItem.ToString()
                                 select g).ToList();
                    grad = query[0];
                }
            }
            catch (NullReferenceException)
            {
                grad = null;
            }
            catch (NotSupportedException)
            {
                grad = null;
            }
            try
            {
                using (var db = new PI2230_DBEntities())
                {
                    var query = (from u in db.Usluga
                                 where u.Naziv == cmbUsluga.SelectedItem.ToString()
                                 select u).ToList();
                    usluga = query[0];
                }
            }
            catch (NullReferenceException)
            {
                usluga = null;
            }
            catch (NotSupportedException)
            {
                usluga = null;
            }
            List<Salon> saloni= repozitorij.DohvatiPodatke(grad, (float)(Convert.ToDouble(numOcjena.Value)), usluga, trackCijenaOd.Value, trackCijenaDo.Value);
            TrazilicaIspis trazilicaIspis = new TrazilicaIspis(saloni,usluga,trackCijenaOd.Value,trackCijenaDo.Value);
            Close();
            trazilicaIspis.ShowDialog();
        }
    }
}
