using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecologie_Donderdag.Domein
{
    public class Natuurgebied
    {
        public Natuurgebied(string id, string nederlandseNaam, float oppervlakte, string locatie)
        {
            Id = id;
            NederlandseNaam = nederlandseNaam;
            Oppervlakte = oppervlakte;
            Locatie = locatie;
        }

        public string Id { get; set; }
        public string NederlandseNaam { get; set; }
        public float Oppervlakte {  get; set; }
        public string Locatie {  get; set; }
    }
}
