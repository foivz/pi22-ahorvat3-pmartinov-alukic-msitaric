using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookfrizApp.Exceptions
{
    public class IspravnostException : ApplicationException
    {
        public string Poruka { get; set; }
        public IspravnostException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
