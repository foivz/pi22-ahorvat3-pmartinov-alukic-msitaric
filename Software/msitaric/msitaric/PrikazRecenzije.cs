using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msitaric
{
    public class PrikazRecenzije
    {
        public int idTermina { get; set; }
        public int? idRecenzija { get; set; }
        public string NazivSalona { get; set; }
        public DateTime Datum { get; set; }
        public TimeSpan Vrijeme { get; set; }
        public int? Ocjena { get; set; }
        public string Opis { get; set; }
    }
}
