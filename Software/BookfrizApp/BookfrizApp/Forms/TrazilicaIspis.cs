using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookfrizApp.Forms
{
    public partial class TrazilicaIspis : Form
    {
        List<Salon> Saloni = new List<Salon>();
        Usluga Usluga = new Usluga();
        int CijenaOd, CijenaDo;
        public TrazilicaIspis(List<Salon> saloni,Usluga usluga,int cijenaOd,int cijenaDo)
        {
            Saloni = saloni;
            Usluga = usluga;
            CijenaOd = cijenaOd;
            CijenaDo = cijenaDo;
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCjenik_Click(object sender, EventArgs e)
        {
            Cjenik cjenik = new Cjenik(dgvTrazilica.CurrentRow.DataBoundItem as Salon, Usluga, CijenaOd, CijenaDo);
            cjenik.ShowDialog();
        }

        private void TrazilicaIspis_Load(object sender, EventArgs e)
        {
            dgvTrazilica.DataSource = Saloni;
            dgvTrazilica.Columns["idSalon"].Visible = false;
            dgvTrazilica.Columns["idGrad"].Visible = false;
            dgvTrazilica.Columns["Grad"].Visible = false;
            dgvTrazilica.Columns["Cjenik"].Visible = false;
            dgvTrazilica.Columns["Vlasnik"].Visible = false;
        }
    }
}
