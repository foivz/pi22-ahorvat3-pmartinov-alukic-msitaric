﻿using System.Collections.Generic;
using System.Linq;
using BookfrizApp.Exceptions;
using BazaPodataka;

namespace BookfrizApp.Classes
{
    public class Repozitorij
    { 
        //Registracija
        public Korisnik korisnik;
        public void DodajUBazu()
        {
            using (var db = new PI2230_DBEntities())
            {
                Klijent klijent = new Klijent
                {
                    idKlijent = db.Klijents.Count() + 1,
                    Ime = korisnik.Ime,
                    Prezime = korisnik.Prezime,
                    Spol = korisnik.Spol,
                    Email = korisnik.Email,
                    BrojTelefona = korisnik.BrojTelefona,
                    Username = korisnik.User,
                    Lozinka = korisnik.Lozinka
                };
                db.Klijents.Add(klijent);
                db.SaveChanges();
            }
        }
        public bool ProvjeriPostojanje(string email)
        {
            using (var db = new PI2230_DBEntities())
            {
                List<Klijent> klijenti = db.Klijents.ToList();
                foreach (Klijent i in klijenti)
                {
                    if (i.Email == email) throw new PostojanjeException("E-mail već postoji u bazi!"); ;
                }
                return true;
            }
        }
        public void KreiranjeUserName()
        {
            string Username = korisnik.Ime.Substring(0, 2).ToLower() + korisnik.Prezime.Substring(0, 3).ToLower() + '0';
            using (var db = new PI2230_DBEntities())
            {
                bool sadrzi = false;
                List<Klijent> klijenti = db.Klijents.ToList();
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
        //Tražilica
        private List<Salon> konacno = new List<Salon>();
        public void Provjera(List<Salon> salon)
        {
            List<Salon> perm = new List<Salon>();
            foreach (Salon i in salon)
            {
                if (konacno.Contains(i)) perm.Add(i);
            }
            konacno = perm.Distinct().ToList();
        }
        public List<Salon> DohvatiPodatke(Grad grad, float minOcjena, string usluga, int cijenaOd, float cijenaDo)
        {
            using (var db = new PI2230_DBEntities())
            {
                bool proslo = false;
                List<Salon> frizerskisalon = db.Salons.ToList();
                if (grad != null)
                {
                    var query = (from s in db.Salons
                                 join g in db.Grads on s.idGrad equals g.idGrad
                                 where g.idGrad == grad.idGrad
                                 select s).ToList();
                    konacno = query;
                    proslo = true;
                }
                if (usluga != null)
                {
                    var query = (from s in db.Salons
                                 join c in db.Cjeniks on s.idSalon equals c.idSalon
                                 join u in db.Uslugas on c.idUsluga equals u.idUsluga
                                 where u.Naziv == usluga
                                 select s).ToList();
                    if (proslo)
                    {
                        Provjera(query);
                    }
                    else
                    {
                        konacno = query;
                        proslo = true;
                    }
                }
                var query1 = (from s in db.Salons
                              join c in db.Cjeniks on s.idSalon equals c.idSalon
                              join u in db.Uslugas on c.idUsluga equals u.idUsluga
                              where u.Cijena >= cijenaOd
                              where u.Cijena <= cijenaDo
                              where s.Ocjena >= minOcjena
                              select s).ToList();
                if (proslo)
                {
                    Provjera(query1);
                }
                else
                {
                    konacno = query1.Distinct().ToList();
                }
                if (konacno.Count() == 0) throw new TrazilicaException("Nemamo salone s takvim zahtjevima");
                return konacno;
            }
        }
        public List<Usluga> PrikaziZeljeneUslugeSalona(Salon salon, string usluga,int cijenaOd,int cijenaDo)
        {
            using (var db = new PI2230_DBEntities())
            {
                if (usluga != null)
                {
                    var query = (from u in db.Uslugas
                                 join c in db.Cjeniks on u.idUsluga equals c.idUsluga
                                 where c.idSalon == salon.idSalon
                                 where u.Naziv == usluga
                                 where u.Cijena>=cijenaOd
                                 where u.Cijena<=cijenaDo
                                 select u).ToList();
                    return query;
                }

                var query1 = (from u in db.Uslugas
                              join c in db.Cjeniks on u.idUsluga equals c.idUsluga
                              where c.idSalon == salon.idSalon
                              where u.Cijena >= cijenaOd
                              where u.Cijena <= cijenaDo 
                              select u).ToList();
                return query1;

            }
        }
    }
}
