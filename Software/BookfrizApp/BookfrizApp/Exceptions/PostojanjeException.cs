using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookfrizApp.Exceptions
{
    public class PostojanjeException : ApplicationException
    {
        public string Poruka { get; set; }
        public PostojanjeException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
