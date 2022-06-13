using BookfrizApp.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BookfrizApp.Exceptions;
using BazaPodataka;

namespace BookfrizApp.Forms
{
    public partial class Trazilica : Form
    {
        Klijent Klijent;
        public Trazilica(Klijent klijent)
        {
            InitializeComponent();
            Klijent = klijent;
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
                var query = (from g in db.Grads
                             select g).ToList();
                foreach (var i in query)
                {
                    cmbGrad.Items.Add(i.Naziv);
                }
                var queryy = (from u in db.Uslugas
                              select u).ToList();
                List<string> x = new List<string>();
                x.Add("-");
                foreach (var i in queryy)
                {
                    x.Add(i.Naziv);
                }
                x=x.Distinct().ToList();
                cmbUsluga.DataSource = x;
            }
        }

        private void btnOdustani_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTrazi_Click_1(object sender, EventArgs e)
        {
            Grad grad = new Grad();
            string usluga=null;
            try
            {
                using (var db = new PI2230_DBEntities())
                {
                    var query = (from g in db.Grads
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
            if (cmbUsluga.SelectedItem.ToString() != "-")
            {
                using (var db = new PI2230_DBEntities())
                {
                    var query = (from u in db.Uslugas
                                 where u.Naziv == cmbUsluga.SelectedItem.ToString()
                                 select u).ToList();
                    usluga = query[0].Naziv;
                }
            }
            try
            {
                List<Salon> saloni = repozitorij.DohvatiPodatke(grad, (float)(Convert.ToDouble(numOcjena.Value)), usluga, trackCijenaOd.Value, trackCijenaDo.Value);
                TrazilicaIspis trazilicaIspis = new TrazilicaIspis(saloni, usluga, trackCijenaOd.Value, trackCijenaDo.Value,this, Klijent);
                trazilicaIspis.ShowDialog();
                
            }
            catch(TrazilicaException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }
    }
}
