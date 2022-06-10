using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msitaric
{
    public class RecenzijeManager
    {
        public List<PrikazRecenzije> DohvatiRecenzije(int idKlijenta)
        {
            using (var context = new PI2230_DBEntities())
            {
                var query = from t in context.Termin.Where(t => t.Datum >= DateTime.Now)
                            where t.IdKlijent == idKlijenta
                            join r in context.Recenzija on t.idTermin equals r.IdTermin into prazno
                            from x in prazno.DefaultIfEmpty()
                            select new PrikazRecenzije {                                
                                idTermina = t.idTermin,
                                idRecenzija = x.IdRecenzija,
                                NazivSalona = t.Salon.Naziv,
                                Datum = t.Datum,
                                Vrijeme = t.Vrijeme,
                                Ocjena = x.Ocjena,
                                Opis = x.Opis
                            };
                return query.ToList();
            }
        }
        public void UnesiRecenziju(string opis, int ocjena, int termin, int? idRecenzija)
        {
            string sql;
            using (var context = new PI2230_DBEntities())
            {
                Recenzija recenzija = new Recenzija
                {
                    IdTermin = termin,
                    Opis = opis,
                    Ocjena = ocjena,
                };
                if (idRecenzija==null)
                {
                    sql = "INSERT INTO Recenzija(Opis, Ocjena, IdTermin) VALUES(" +
                        "'" + recenzija.Opis + "', '" + recenzija.Ocjena + "', '" + recenzija.IdTermin + "')";
                }
                else
                {
                    sql = "UPDATE Recenzija SET Opis='" + recenzija.Opis + "', Ocjena='" + recenzija.Ocjena + "'," +
                        "IdTermin="+recenzija.IdTermin+" WHERE IdRecenzija='"+ idRecenzija + "'";
                }
                //UPDATE Recenzija SET Opis='ad', Ocjena='2', IdTermin=1 WHERE IdRecenzija='1'
                context.Database.ExecuteSqlCommand(sql);
            }            
        }
    }
}
