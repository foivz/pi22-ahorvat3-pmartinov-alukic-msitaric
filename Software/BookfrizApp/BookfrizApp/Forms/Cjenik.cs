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
    public partial class Cjenik : Form
    {
        Salon Salon = new Salon();
        Usluga Usluga = new Usluga();
        int CijenaOd, CijenaDo;
        public Cjenik(Salon salon,Usluga usluga,int cijenaOd,int cijenaDo)
        {
            Salon = salon;
            Usluga = usluga;
            CijenaOd = cijenaOd;
            CijenaDo = cijenaDo;
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cjenik_Load(object sender, EventArgs e)
        {
            Repozitorij repozitorij = new Repozitorij();
            dgvCjenik.DataSource = repozitorij.PrikaziZeljeneUslugeSalona(Salon, Usluga, CijenaOd, CijenaDo);
            dgvCjenik.Columns["Cjenik"].Visible = false;
            dgvCjenik.Columns["idUsluga"].Visible = false;
        }
        
    }
}
