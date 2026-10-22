using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecologie_Donderdag.Domein
{
    public class AnderstaligeNaam
    {
        public AnderstaligeNaam(string naam, string taal)
        {
            Naam = naam;
            Taal = taal;
        }

        public string Naam {  get; set; }
        public string Taal { get; set; }
    }
}
