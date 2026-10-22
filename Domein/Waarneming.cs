using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecologie_Donderdag.Domein
{
    public class Waarneming
    {
        public Waarneming(int aantal, DateTime datum, Onderzoeker onderzoeker, Natuurgebied natuurgebied, Diersoort diersoort)
        {
            Aantal = aantal;
            Datum = datum;
            Onderzoeker = onderzoeker;
            Natuurgebied = natuurgebied;
            Diersoort = diersoort;
        }

        public int Aantal {  get; set; }
        public DateTime Datum { get; set; }
        public Onderzoeker Onderzoeker { get; set; }
        public Natuurgebied Natuurgebied { get; set; }
        public Diersoort Diersoort { get; set; }
    }
}
