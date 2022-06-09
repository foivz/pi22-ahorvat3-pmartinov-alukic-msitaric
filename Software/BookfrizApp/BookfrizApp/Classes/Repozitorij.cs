using BookfrizApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookfrizApp.Classes
{
    public class Repozitorij
    {
        public Korisnik korisnik;
        public void DodajUBazu()
        {
            using (var db = new PI2230_DBEntities())
            {
                Klijent klijent = new Klijent
                {
                    idKlijent = db.Klijent.Count() + 1,
                    Ime = korisnik.Ime,
                    Prezime = korisnik.Prezime,
                    Spol = korisnik.Spol,
                    Email = korisnik.Email,
                    BrojTelefona = korisnik.BrojTelefona,
                    Username = korisnik.User,
                    Lozinka = korisnik.Lozinka
                };
                db.Klijent.Add(klijent);
                db.SaveChanges();

            }
        }
        public bool ProvjeriPostojanje(string email)
        {
            using (var db = new PI2230_DBEntities())
            {
                List<Klijent> klijenti = db.Klijent.ToList();
                foreach (Klijent i in klijenti)
                {
                    if (i.Email == email) return true;
                }
                return false;
            }
        }
        public void KreiranjeUserName()
        {
            string Username = korisnik.Ime.Substring(0, 2) + korisnik.Prezime.Substring(0, 3) + '0';
            using (var db = new PI2230_DBEntities())
            {
                bool sadrzi = false;
                List<Klijent> klijenti = db.Klijent.ToList();
                for (int i = 1; i < 1000; i++)
                {
                    foreach (Klijent j in klijenti)
                    {
                        if (Username == j.Username) sadrzi = true;
                    }
                    if (!sadrzi)
                    {
                        korisnik.User = Username;
                        return;
                    }
                    Username = Username.Remove(Username.Length - 1);
                    Username += i;
                    sadrzi = false;
                }
            }
        }
        public Korisnik Korisnik { get; set; }
        public FrizerskiSalon FrizerskiSalon { get; set; }
        List<Salon> konacno = new List<Salon>();
        public void Provjera(List<Salon> salon)
        {
            List<Salon> perm = new List<Salon>();
            foreach (Salon i in salon)
            {
                if (konacno.Contains(i)) perm.Add(i);
            }
            konacno = perm;
        }
        public List<Salon> DohvatiPodatke(Grad grad, float minOcjena, Usluga usluga, int cijenaOd, float cijenaDo)
        {
            using (var db = new PI2230_DBEntities())
            {
                bool proslo = false;
                List<Salon> frizerskisalon = db.Salon.ToList();
                if (grad != null)
                {
                    var query = (from s in db.Salon
                                 where s.Grad == grad
                                 select s).ToList();
                    konacno = query;
                    proslo = true;
                }
                if (minOcjena > 1)
                {
                    var query = (from s in db.Salon
                                 where s.Ocjena >= minOcjena
                                 select s).ToList();
                    if (proslo)
                    {
                        Provjera(query);
                    }
                    proslo = true;
                }
                if (usluga != null)
                {
                    var query = (from s in db.Cjenik
                                 where s.Usluga == usluga
                                 select s.Salon).ToList();
                    if (proslo)
                    {
                        Provjera(query);
                    }
                    proslo = true;
                }
                if (cijenaOd != 0)
                {
                    var query = (from c in db.Cjenik
                                 where c.Usluga.Cijena >= cijenaOd
                                 select c.Salon).ToList();
                    if (proslo)
                    {
                        Provjera(query);
                    }
                    proslo = true;
                }
                if (cijenaDo > 0)
                {
                    var query = (from c in db.Cjenik
                                 where c.Usluga.Cijena <= cijenaDo
                                 select c.Salon).ToList();
                    if (proslo)
                    {
                        Provjera(query);
                    }
                }
                return konacno;
            }
        }
    }
}
