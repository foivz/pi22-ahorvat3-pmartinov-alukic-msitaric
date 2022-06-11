using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msitaric
{
    public class MojeAkcijeManager
    {
        public List<MojeAkcije> DohvatiKlijentAkcije(string NazivSalona)
        {
            using (var context = new PI2230_DBEntities())
            {
                var query = from a in context.Akcija
                            join c in context.Cjenik on a.IdCjenik equals c.idCjenik
                            join s in context.Salon on c.idSalon equals s.idSalon
                            where s.Naziv == NazivSalona
                            select new MojeAkcije
                            {
                                idAkcije = a.IdAkcija,
                                Opis = a.OpisAkcije,
                                DatumIsteka = a.VrijemeTrajanja,
                                NovaCijena = a.NovaCijena
                            };
                List<MojeAkcije> mojeAkcije = query.ToList();
                mojeAkcije = ProvjeriDatum(mojeAkcije);
                return mojeAkcije;
            }
        }

        public void ObrisiAkciju(MojeAkcije akcija)
        {
            using (var context = new PI2230_DBEntities())
            {
                string sql = "DELETE FROM Akcija WHERE IdAkcija='"+akcija.idAkcije+"'";
                context.Database.ExecuteSqlCommand(sql);
            }
        }
        public List<Usluga> DohvatiUslugeSalona(int idSalona)
        {
            using (var context = new PI2230_DBEntities())
            {
                var query = from c in context.Cjenik
                            join u in context.Usluga on c.idUsluga equals u.idUsluga
                            where c.idSalon==idSalona
                            select u;
                return query.ToList();
            }
        }
        public void UnesiAkciju(string opis, DateTime datumIsteka, decimal novaCijena, Usluga usluga, int idSalona)
        {
            using (var context = new PI2230_DBEntities())
            {
                var query = from c in context.Cjenik
                            where c.idSalon == idSalona && c.idUsluga == usluga.idUsluga
                            select c;
                List<Cjenik> cjenik = query.ToList();
                string datum = datumIsteka.Day + "-" + datumIsteka.Month + "-" + datumIsteka.Year;
                string sql = "INSERT INTO Akcija(OpisAkcije, VrijemeTrajanja, NovaCijena, IdCjenik) " +
                    "VALUES('" + opis + "', '" + datum + "', '" + novaCijena + "', '" + cjenik[0].idCjenik + "')";
                context.Database.ExecuteSqlCommand(sql);
            }
        }

        private List<MojeAkcije> ProvjeriDatum(List<MojeAkcije> mojeAkcije)
        {
            List<MojeAkcije> akcijeZaBrisanje = new List<MojeAkcije>();
            foreach (var akcija in mojeAkcije)
            {
                DateTime dat = Convert.ToDateTime(akcija.DatumIsteka);
                if (dat.Date < DateTime.Now.Date)
                {
                    akcijeZaBrisanje.Add(akcija);
                    using (var context = new PI2230_DBEntities())
                    {
                        string sql = "DELETE FROM Akcija WHERE IdAkcija='" + akcija.idAkcije + "'";
                        context.Database.ExecuteSqlCommand(sql);
                    }
                }
            }
            foreach (var akcija in akcijeZaBrisanje)
            {
                mojeAkcije.Remove(akcija);
            }
            return mojeAkcije;
        }
        public bool ProvjeriIstekDatuma(DateTime datum)
        {
            if (datum.Date > DateTime.Now.Date)
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
