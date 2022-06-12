using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaPodataka
{
    public class Baza
    {
        public bool ProvjeriPostojiKlijent (string korisnickoIme, string lozinka)
        {
            bool postoji = false;
            Klijent klijent = new Klijent();

            using (var con = new PI2230_DBEntities())
            {
                var upit = from k in con.Klijents
                           where k.Username == korisnickoIme && k.Lozinka == lozinka
                           select k as Klijent;
                klijent = upit.FirstOrDefault();
            }

            if (klijent == null)
            {
                postoji = false;
            } else
            {
                postoji = true;
            }

            return postoji;
        }

        public bool ProvjeriPostojiVlasnik(string korisnickoIme, string lozinka)
        {
            bool postoji = false;
            Vlasnik vlasnik = new Vlasnik();

            using (var con = new PI2230_DBEntities())
            {
                var upit = from v in con.Vlasniks
                           where v.Username == korisnickoIme && v.Lozinka == lozinka
                           select v as Vlasnik;
                vlasnik = upit.FirstOrDefault();
            }

            if (vlasnik == null)
            {
                postoji = false;
            }
            else
            {
                postoji = true;
            }

            return postoji;
        }

        public Klijent DohvatiKlijenta(string korisnickoIme, string lozinka)
        {
            Klijent klijent = new Klijent();

            using (var con = new PI2230_DBEntities())
            {
                var upit = from k in con.Klijents
                           where k.Username == korisnickoIme && k.Lozinka == lozinka
                           select k as Klijent;
                klijent = upit.FirstOrDefault();
            }

            return klijent;
        }

        public Vlasnik DohvatiVlasnika(string korisnickoIme, string lozinka)
        {
            Vlasnik vlasnik = new Vlasnik();

            using (var con = new PI2230_DBEntities())
            {
                var upit = from v in con.Vlasniks
                           where v.Username == korisnickoIme && v.Lozinka == lozinka
                           select v as Vlasnik;
                vlasnik = upit.FirstOrDefault();
            }

            return vlasnik;
        }

        public void AzurirajKlijenta(Klijent klijent)
        {
            //dodati kod za azuriranje klijenta
        }

        public Salon DohvatiSalon(int? idSalona)
        {
            Salon salon = new Salon();

            using (var con = new PI2230_DBEntities())
            {
                var upit = from s in con.Salons
                           where s.idSalon == idSalona
                           select s as Salon;
                salon = upit.FirstOrDefault();
            }

            return salon;
        }

    }
}
