using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BookfrizApp.Forms
{
    public partial class SaloniUBlizini : Form
    {
        public SaloniUBlizini()
        {
            InitializeComponent();
        }
        private GMapOverlay korisnik = new GMapOverlay("Korisnik");
        private GMapOverlay saloni = new GMapOverlay("Saloni");
        private List<GMapMarker> markeriSalona = new List<GMapMarker>();
        private void Osvjezi()
        {
            mapa.MapProvider = GMapProviders.OpenStreetMap;
            mapa.DragButton = MouseButtons.Left;
            mapa.ShowCenter = false;
            mapa.SetPositionByKeywords("Varaždin, Hrvatska");
            mapa.MaxZoom = 25;
            mapa.Zoom = 15;
            if(korisnik.Markers.Count()==1) korisnik.Markers.RemoveAt(0);
        }
        private void SaloniUBlizini_Load(object sender, EventArgs e)
        {
            PostaviSalone();
            Osvjezi();
        }
        private void PostaviSalone()
        {
            using (var db = new PI2230_DBEntities())
            {
                var query = (from s in db.Salon
                             join g in db.Grad on s.idGrad equals g.idGrad
                             select ( new { s, g.Naziv })).ToList();
                var popisSalona = query;
                List<PointLatLng> tockeSalona = new List<PointLatLng>();
                foreach (var i in popisSalona)
                {
                    PointLatLng x = new PointLatLng();
                    mapa.GetPositionByKeywords(i.s.Adresa+", "+i.Naziv, out x);
                    tockeSalona.Add(x);
                }
                foreach (var i in tockeSalona)
                {
                    markeriSalona.Add(new GMarkerGoogle(i, GMarkerGoogleType.red));
                }
                int y = 0;
                foreach (var i in markeriSalona)
                {
                    i.ToolTipText = popisSalona[y].s.idSalon+"\nNaziv: " + popisSalona[y].s.Naziv + "\nBroj Telefona: " + popisSalona[y].s.BrojTelefona + "\nEmail: " + popisSalona[y].s.Email + "\nAdresa: " + popisSalona[y].s.Adresa + ", " + popisSalona[y].Naziv + "\nOcjena: " + popisSalona[y].s.Ocjena;
                    saloni.Markers.Add(i);
                    y++;
                }
                mapa.Overlays.Add(saloni);
            }
        }

        private void btnTraži_Click(object sender, EventArgs e)
        {
            if(korisnik.Markers.Count()==1) korisnik.Markers.RemoveAt(0);
            mapa.SetPositionByKeywords(txtUlica.Text + ", " + txtGrad.Text);
            PointLatLng lokacijaKorisnika = new PointLatLng();
            mapa.GetPositionByKeywords(txtUlica.Text + ", " + txtGrad.Text,out lokacijaKorisnika);
            GMapMarker covjek = new GMarkerGoogle(lokacijaKorisnika, GMarkerGoogleType.blue_dot);
            korisnik.Markers.Add(covjek);
            mapa.Overlays.Add(korisnik);
        }

        private void btnOsvježi_Click(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void mapa_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            int novaLinija = item.ToolTipText.IndexOf("\n");
            int x= Convert.ToInt32(item.ToolTipText.Substring(0, novaLinija));
            Salon salon = new Salon();
            using (var db=new PI2230_DBEntities())
            {
                var query = (from s in db.Salon
                             where s.idSalon == x
                             select s).ToList();
                salon = query[0];
            }
            //otvori taj salon
        }
    }
}
