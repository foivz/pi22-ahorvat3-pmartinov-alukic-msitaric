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
        Obavijesti obavijesti = new Obavijesti();
        Baza baza = new Baza();
      
        public FormObavijestiKlijenta(Klijent prijavljeniKlijent)
        {
            InitializeComponent();
            klijent = prijavljeniKlijent;
            PrikaziObavijesti();
            obavijesti.id_klijenta = klijent.idKlijent;
        }

        private void PrikaziObavijesti()
        {
            Obavijesti obavijest = baza.DohvatiObavijest(klijent.idKlijent);
            if (obavijest != null)
            {
                if (obavijest.sve_obavijesti == 1)
                {
                    cbSveObavijesti.Checked = true;
                }
                if (obavijest.bez_obavijesti == 1)
                {
                    cbBezObavijesti.Checked = true;
                }
                if (obavijest.obavijesti_jedan_dan_prije == 1)
                {
                    cbObavijestiJedanDanPrije.Checked = true;
                }
                if (obavijest.obavijesti_jedan_sat_prije == 1)
                {
                    cbObavijestiJedanSatPrije.Checked = true;
                }
            }
        }
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (cbBezObavijesti.Checked)
            {
                obavijesti.bez_obavijesti = 1;
            }
            else
            {
                obavijesti.bez_obavijesti = 0;
            }
            if (cbSveObavijesti.Checked)
            {
                obavijesti.sve_obavijesti = 1;
            }
            else
            {
                obavijesti.sve_obavijesti = 0;
            }
            if (cbObavijestiJedanDanPrije.Checked)
            {
                obavijesti.obavijesti_jedan_dan_prije = 1;
            }
            else
            {
                obavijesti.obavijesti_jedan_dan_prije = 0;
            }
            if (cbObavijestiJedanSatPrije.Checked)
            {
                obavijesti.obavijesti_jedan_sat_prije = 1;
            }
            else
            {
                obavijesti.obavijesti_jedan_sat_prije = 0;
            }
            baza.DodajObavijesti(obavijesti);
            MessageBox.Show("Podati su uspješno spremljeni!");
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
