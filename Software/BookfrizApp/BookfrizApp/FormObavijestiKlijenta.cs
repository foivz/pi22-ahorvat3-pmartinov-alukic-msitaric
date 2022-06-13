using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BazaPodataka;

namespace BookfrizApp
{
    public partial class FormObavijestiKlijenta : Form
    {
        Klijent klijent = new Klijent();
        public FormObavijestiKlijenta(Klijent prijavljeniKlijent)
        {
            InitializeComponent();
            klijent = prijavljeniKlijent;
        }

        /*public FormObavijestiKlijenta()
        {
            InitializeComponent();
            klijent = new Klijent
            {
                Ime = "Kornelija",
                Prezime = "Petunija",
                Email = "kornelija@foi.hr",
                Spol = "ženski",
                BrojTelefona = "0987654321",
                Username = "kor123",
                Lozinka = "petunija123"
            };
        }*/

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            Obavijesti obavijesti = new Obavijesti();

            using (var con = new PI2230_DBEntities())
            {
               
                obavijesti.id_klijenta = klijent.idKlijent;
                if (cbSveObavijesti.Checked)
                {
                    obavijesti.sve_obavijesti = 1;
                }
                if (cbBezObavijesti.Checked)
                {
                    obavijesti.sve_obavijesti = 1;
                }
                if (cbObavijestiJedanDanPrije.Checked)
                {
                    obavijesti.obavijesti_jedan_dan_prije = 1;
                }
                if (cbObavijestiJedanSatPrije.Checked)
                {
                    obavijesti.obavijesti_jedan_sat_prije = 1;
                }
                con.Obavijestis.Add(obavijesti);
                con.SaveChanges();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
