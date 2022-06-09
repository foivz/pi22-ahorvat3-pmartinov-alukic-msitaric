using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msitaric
{
    public class Saloni
    {
        public bool ProvjeraPodataka(string podatak)
        {
            bool ispravno = true;
            if(podatak.Contains("'") || podatak.Contains('"') || podatak.Contains("<") || podatak.Contains(">"))
            {
                ispravno = false;
            }
            return ispravno;
        }
        public List<string> DohvatiSalone()
        {
            List<string> popisSalona = new List<string>();
            popisSalona.Add("Svi saloni");
            using (var context = new PI2230_DBEntities())
            {
                var query = from s in context.Salon
                            select s.Naziv;

                popisSalona.AddRange(query.ToList());
            }
            return popisSalona;
        }
        public List<string> DohvatiUsluge()
        {
            List<string> popisUsluga = new List<string>();
            popisUsluga.Add("Sve usluge");
            using (var context = new PI2230_DBEntities())
            {
                var query = from u in context.Usluga
                            select u.Naziv;

                popisUsluga.AddRange(query.ToList());
            }
            return popisUsluga;
        }

        public List<PopisTermina> DohvatiTermine(string salon, string usluga, int vrijeme)      
        {
            //INSERT INTO Termin("Datum", "Vrijeme", "IdKlijent", "IdSalon") VALUES ('9-6-2022', '7:0', 1, 1)
            List<PopisTermina> sviSaloniIUsluge;
            using (var context = new PI2230_DBEntities())
            {
                var query = from t in context.Termin
                            where t.Vrijeme.Hours == vrijeme
                            select t;
                List<Termin> zauzetiTermini = query.ToList();
                
                    if(salon=="Svi saloni" && usluga == "Sve usluge")
                    {
                    var query2 = from c in context.Cjenik
                                 join s in context.Salon on c.idSalon equals s.idSalon
                                 join u in context.Usluga on c.idUsluga equals u.idUsluga
                                 join a in context.Akcija on c.idCjenik equals a.IdCjenik into akcija
                                 join t in context.Termin on c.idSalon equals t.IdSalon into upit
                                 from ime in upit.DefaultIfEmpty()
                                 where ime.Vrijeme.Hours != vrijeme
                                 from ak in akcija.DefaultIfEmpty()
                                 select new PopisTermina
                                 {
                                     Salon = s.Naziv,
                                     Usluga = u.Naziv,
                                     NormalnaCijena = u.Cijena.ToString(),
                                     AkcijskaCijena = ak.NovaCijena.ToString()
                                     };

                        sviSaloniIUsluge = query2.ToList();
                        return sviSaloniIUsluge;
                    }

                    if (usluga == "Sve usluge")
                    {
                        var query2 = from c in context.Cjenik
                                     join s in context.Salon on c.idSalon equals s.idSalon
                                     join u in context.Usluga on c.idUsluga equals u.idUsluga
                                     where s.Naziv == salon
                                     join a in context.Akcija on c.idCjenik equals a.IdCjenik into akcija
                                     join t in context.Termin on c.idSalon equals t.IdSalon into upit
                                     from ime in upit.DefaultIfEmpty()
                                     from ak in akcija.DefaultIfEmpty()
                                     where ime.Vrijeme.Hours != vrijeme
                                     select new PopisTermina
                                     {
                                         Salon = s.Naziv,
                                         Usluga = u.Naziv,
                                         NormalnaCijena = u.Cijena.ToString(),
                                         AkcijskaCijena = ak.NovaCijena.ToString()
                                     };

                        sviSaloniIUsluge = query2.ToList();
                        return sviSaloniIUsluge;
                    }

                    if (salon == "Svi saloni")
                    {
                        var query2 = from c in context.Cjenik
                                     join s in context.Salon on c.idSalon equals s.idSalon
                                     join u in context.Usluga on c.idUsluga equals u.idUsluga
                                     where u.Naziv == usluga
                                     join a in context.Akcija on c.idCjenik equals a.IdCjenik into akcija
                                     join t in context.Termin on c.idSalon equals t.IdSalon into upit
                                     from ime in upit.DefaultIfEmpty()
                                     from ak in akcija.DefaultIfEmpty()
                                     where ime.Vrijeme.Hours != vrijeme
                                     select new PopisTermina
                                     {
                                         Salon = s.Naziv,
                                         Usluga = u.Naziv,
                                         NormalnaCijena = u.Cijena.ToString(),
                                         AkcijskaCijena = ak.NovaCijena.ToString()
                                     };

                        sviSaloniIUsluge = query2.ToList();
                        return sviSaloniIUsluge;
                    }

                    var query3 = from c in context.Cjenik
                                 join s in context.Salon on c.idSalon equals s.idSalon
                                 join u in context.Usluga on c.idUsluga equals u.idUsluga
                                 where u.Naziv == usluga && s.Naziv == salon
                                 join a in context.Akcija on c.idCjenik equals a.IdCjenik into akcija
                                 join t in context.Termin on c.idSalon equals t.IdSalon into upit
                                 from ime in upit.DefaultIfEmpty()
                                 from ak in akcija.DefaultIfEmpty()
                                 where ime.Vrijeme.Hours != vrijeme
                                 select new PopisTermina
                                 {
                                     Salon = s.Naziv,
                                     Usluga = u.Naziv,
                                     NormalnaCijena = u.Cijena.ToString(),
                                     AkcijskaCijena = ak.NovaCijena.ToString()
                                 };

                    sviSaloniIUsluge = query3.ToList();
                    
            }
            return sviSaloniIUsluge;
        }

        public void ObaviRezervaciju(PopisTermina termin, int vrijeme, DateTime datum, int idKorisnika)
        {
            using (var context = new PI2230_DBEntities())
            {
                var query = from s in context.Salon
                            where s.Naziv == termin.Salon
                            select s.idSalon;
                int idSalona = query.First();
                Termin ter = new Termin
                {
                    Vrijeme = TimeSpan.Parse(vrijeme.ToString()),
                    Datum = datum,
                    IdSalon = idSalona,
                    IdKlijent = idKorisnika
                };
                //context.Termin.Add(ter);
                //context.SaveChanges();
            }            
        }
    }
}
