using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msitaric
{
    public class AkcijeManager
    {
        public List<OpisAkcije> DohvatiSveAkcije()
        {
            using (var context = new PI2230_DBEntities())
            {
                var query = from a in context.Akcija
                            join c in context.Cjenik on a.IdCjenik equals c.idCjenik
                            join s in context.Salon on c.idSalon equals s.idSalon
                            join u in context.Usluga on c.idUsluga equals u.idUsluga
                            select new OpisAkcije {
                                Salon = s.Naziv,
                                Usluga = u.Naziv,
                                Opis = a.OpisAkcije,
                                AkcijskaCijena = a.NovaCijena,
                                DatumIsteka = a.VrijemeTrajanja
                            };
                return query.ToList();
            }
        }
        public List<OpisAkcije> DohvatiAkcije(string imeSalon, string imeUsluga)
        {
            using (var context = new PI2230_DBEntities())
            {
                if(imeSalon == "Svi saloni" && imeUsluga == "Sve usluge")
                {
                     return DohvatiSveAkcije();
                }
                if (imeSalon == "Svi saloni")
                {
                    var query = from a in context.Akcija
                                join c in context.Cjenik on a.IdCjenik equals c.idCjenik
                                join s in context.Salon on c.idSalon equals s.idSalon
                                join u in context.Usluga on c.idUsluga equals u.idUsluga
                                where u.Naziv == imeUsluga
                                select new OpisAkcije
                                {
                                    Salon = s.Naziv,
                                    Usluga = u.Naziv,
                                    Opis = a.OpisAkcije,
                                    AkcijskaCijena = a.NovaCijena,
                                    DatumIsteka = a.VrijemeTrajanja
                                };
                    return query.ToList();
                }
                if (imeUsluga == "Sve usluge")
                {
                    var query = from a in context.Akcija
                                join c in context.Cjenik on a.IdCjenik equals c.idCjenik
                                join s in context.Salon on c.idSalon equals s.idSalon
                                where s.Naziv == imeSalon
                                join u in context.Usluga on c.idUsluga equals u.idUsluga
                                select new OpisAkcije
                                {
                                    Salon = s.Naziv,
                                    Usluga = u.Naziv,
                                    Opis = a.OpisAkcije,
                                    AkcijskaCijena = a.NovaCijena,
                                    DatumIsteka = a.VrijemeTrajanja
                                };
                    return query.ToList();
                }
                var query2 = from a in context.Akcija
                            join c in context.Cjenik on a.IdCjenik equals c.idCjenik
                            join s in context.Salon on c.idSalon equals s.idSalon
                            where s.Naziv == imeSalon
                            join u in context.Usluga on c.idUsluga equals u.idUsluga
                            where u.Naziv == imeUsluga
                            select new OpisAkcije
                            {
                                Salon = s.Naziv,
                                Usluga = u.Naziv,
                                Opis = a.OpisAkcije,
                                AkcijskaCijena = a.NovaCijena,
                                DatumIsteka = a.VrijemeTrajanja
                            };
                return query2.ToList();
            }
        }   
    }
}
