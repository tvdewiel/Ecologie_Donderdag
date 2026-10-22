using Ecologie_Donderdag.Domein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecologie_Donderdag.Beheerders
{
    public class OnderzoekerBeheerder
    {
        private Dictionary<int, Onderzoeker> onderzoekers = new();

        public OnderzoekerBeheerder()
        {
            onderzoekers.Add(1,new Onderzoeker("jos","jos@gmail",1));
        }

        public Onderzoeker SelecteerOnderzoeker(int id)
        {
            return onderzoekers[id];
        }
    }
}
