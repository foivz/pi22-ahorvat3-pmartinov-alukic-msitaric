using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registracija_klasa
{
    public class Repozitorij : PI2230_DBEntities
    {
        public Korisnik korisnik;
        public void DodajUBazu()
        {
            using(var db=new PI2230_DBEntities())
            {
                Klijent klijent = new Klijent
                {
                    idKlijent = db.Klijent.Count()+1,
                    Ime = korisnik.Ime,
                    Prezime=korisnik.Prezime,
                    Spol=korisnik.Spol,
                    Email=korisnik.Email,
                    BrojTelefona=korisnik.BrojTelefona,
                    Username=korisnik.User,
                    Lozinka=korisnik.Lozinka
                };
                db.Klijent.Add(klijent);
                db.SaveChanges();
            }
        }
        public bool ProvjeriPostojanje(string email)
        {
            using(var db=new PI2230_DBEntities())
            {
                List<Klijent> klijenti = db.Klijent.ToList();
                foreach(Klijent i in klijenti)
                {
                    if (i.Email == email) return true;
                }
                return false;
            }
        } 
        public void KreiranjeUserName()
        {
            string Username = korisnik.Ime.Substring(0,2) + korisnik.Prezime.Substring(0,3)+'0';
            using(var db=new PI2230_DBEntities())
            {
                bool sadrzi = false;
                List<Klijent> klijenti = db.Klijent.ToList();
                for(int i = 1; i < 1000; i++)
                {
                    foreach(Klijent j in klijenti)
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
    }
}
