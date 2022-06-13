using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookfrizApp.Exceptions
{
    class TrazilicaException : ApplicationException
    {
        public string Poruka { get; set; }
        public TrazilicaException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
