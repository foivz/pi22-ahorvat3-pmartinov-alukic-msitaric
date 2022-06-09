using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa_Registracija
{
    public class Korisnik
    {
        public int IdKorisnik { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Spol { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public string User { get; set; }
        public string Lozinka { get; set; }
        public Korisnik(string ime, string prezime, string spol, string brojTelefona, string email, string lozinka)
        {
            Ime = ime;
            Spol = spol;
            Prezime = prezime;
            BrojTelefona = brojTelefona;
            Email = email;
            Lozinka = lozinka;
        }
    }
}
