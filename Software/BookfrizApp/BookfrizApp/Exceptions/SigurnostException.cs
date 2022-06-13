using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookfrizApp.Exceptions
{
    public class SigurnostException : ApplicationException
    {
        public string Poruka { get; set; }
        public SigurnostException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
