using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msitaric
{
    public class SaloniManager
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

        public List<PopisTermina> DohvatiTermine(string salon, string usluga, int vrijeme, DateTime datum, int v)      
        {
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
                                 from ak in akcija.DefaultIfEmpty()
                                 select new PopisTermina
                                 {
                                     Datum = datum.Date,
                                     Salon = s.Naziv,
                                     Usluga = u.Naziv,
                                     NormalnaCijena = u.Cijena.ToString(),
                                     AkcijskaCijena = ak.NovaCijena.ToString()
                                     };

                    sviSaloniIUsluge = query2.ToList();

                    sviSaloniIUsluge = ProvjeraIspravnosti(sviSaloniIUsluge, datum, v);                   


                    return sviSaloniIUsluge;
                    }

                    if (usluga == "Sve usluge")
                    {
                        var query2 = from c in context.Cjenik
                                     join s in context.Salon on c.idSalon equals s.idSalon
                                     join u in context.Usluga on c.idUsluga equals u.idUsluga
                                     where s.Naziv == salon
                                     join a in context.Akcija on c.idCjenik equals a.IdCjenik into akcija
                                     from ak in akcija.DefaultIfEmpty()
                                     select new PopisTermina
                                     {
                                         Salon = s.Naziv,
                                         Usluga = u.Naziv,
                                         NormalnaCijena = u.Cijena.ToString(),
                                         AkcijskaCijena = ak.NovaCijena.ToString()
                                     };

                        sviSaloniIUsluge = query2.ToList();
                        sviSaloniIUsluge = ProvjeraIspravnosti(sviSaloniIUsluge, datum, v);
                        return sviSaloniIUsluge;
                    }

                    if (salon == "Svi saloni")
                    {
                        var query2 = from c in context.Cjenik
                                     join s in context.Salon on c.idSalon equals s.idSalon
                                     join u in context.Usluga on c.idUsluga equals u.idUsluga
                                     where u.Naziv == usluga
                                     join a in context.Akcija on c.idCjenik equals a.IdCjenik into akcija
                                     from ak in akcija.DefaultIfEmpty()
                                     select new PopisTermina
                                     {
                                         Salon = s.Naziv,
                                         Usluga = u.Naziv,
                                         NormalnaCijena = u.Cijena.ToString(),
                                         AkcijskaCijena = ak.NovaCijena.ToString()
                                     };

                        sviSaloniIUsluge = query2.ToList();
                        sviSaloniIUsluge = ProvjeraIspravnosti(sviSaloniIUsluge, datum, v);
                        return sviSaloniIUsluge;
                    }

                    var query3 = from c in context.Cjenik
                                 join s in context.Salon on c.idSalon equals s.idSalon
                                 join u in context.Usluga on c.idUsluga equals u.idUsluga
                                 where u.Naziv == usluga && s.Naziv == salon
                                 join a in context.Akcija on c.idCjenik equals a.IdCjenik into akcija
                                 from ak in akcija.DefaultIfEmpty()
                                 select new PopisTermina
                                 {
                                     Salon = s.Naziv,
                                     Usluga = u.Naziv,
                                     NormalnaCijena = u.Cijena.ToString(),
                                     AkcijskaCijena = ak.NovaCijena.ToString()
                                 };

                    sviSaloniIUsluge = query3.ToList();
                    sviSaloniIUsluge = ProvjeraIspravnosti(sviSaloniIUsluge, datum, v);
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
                    Vrijeme = TimeSpan.Parse(vrijeme.ToString()+":00:00"),
                    Datum = datum.Date,
                    IdSalon = idSalona,
                    IdKlijent = idKorisnika
                };

                string sql = "INSERT INTO Termin(Datum, Vrijeme, IdKlijent, IdSalon) " +
                    "VALUES ('"+ ter.Datum.Month + "-"+ ter.Datum.Day + "-"+ ter.Datum.Year + 
                    "', '" + ter.Vrijeme + "', " + ter.IdKlijent + ", " + ter.IdSalon + ")";
                context.Database.ExecuteSqlCommand(sql);
            }            
        }
        private List<PopisTermina> ProvjeraIspravnosti(List<PopisTermina> sviSaloniIUsluge, DateTime datum, int v)
        {
            using (var context = new PI2230_DBEntities())
            {
                var q = from t in context.Termin
                        select t;
                List<Termin> ter = q.ToList();
                List<PopisTermina> brisanjeSalonUsluga = new List<PopisTermina>();
                foreach (var saloniUsluge in sviSaloniIUsluge)
                {
                    foreach (var termin in ter)
                    {
                        if (datum.Date == termin.Datum.Date && saloniUsluge.Salon == termin.Salon.Naziv && termin.Vrijeme.Hours == v)
                        {
                            brisanjeSalonUsluga.Add(saloniUsluge);
                        }
                    }
                }
                foreach (var obrisi in brisanjeSalonUsluga)
                {
                    sviSaloniIUsluge.Remove(obrisi);
                }


                return sviSaloniIUsluge;
            }
        }
        public bool ProvjeriIspravnostDatuma(DateTime datum)
        {
            if (datum.Date < DateTime.Now.Date)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
