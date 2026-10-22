using Ecologie_Donderdag.Domein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecologie_Donderdag.Beheerders
{
    public class NatuurBeheerder
    {
        private Dictionary<string,Natuurgebied> natuurgebieden = new(); //dit wordt later de databank

        public NatuurBeheerder()
        {
            natuurgebieden.Add("A1", new Natuurgebied("A1", "Hoge Venen", 158, "Luik"));
        }

        public Natuurgebied RegistreerNatuurgebied(string id, string locatie,string nedNaam,float oppervlakte)
        {
            Natuurgebied natuurgebied = new Natuurgebied(id,nedNaam,oppervlakte,locatie);
            natuurgebieden.Add(id,natuurgebied);
            return natuurgebied;
        }
        public Natuurgebied SelecteerNatuurgebied(string id)
        {
            return natuurgebieden[id];
        }
    }
}
