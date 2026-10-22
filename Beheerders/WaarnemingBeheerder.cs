using Ecologie_Donderdag.Domein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecologie_Donderdag.Beheerders
{
    public class WaarnemingBeheerder
    {
        private List<Waarneming> waarnemingen = new();
        public Waarneming RegistreerWaarneming(int aantal,DateTime datum,Diersoort diersoort,Onderzoeker onderzoeker,Natuurgebied natuurgebied)
        {
            Waarneming waarneming = new Waarneming(aantal, datum, onderzoeker, natuurgebied, diersoort);
            waarnemingen.Add(waarneming);
            return waarneming;
        }
    }
}
