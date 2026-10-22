using Ecologie_Donderdag.Domein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecologie_Donderdag.Beheerders
{
    public class DiersoortBeheerder
    {
        private Dictionary<string, Diersoort> diersoorten = new();

        public DiersoortBeheerder()
        {
            diersoorten.Add("vos", new Diersoort("vos", "wet vos", false));
            diersoorten.Add("wolf", new Diersoort("wolf", "wet wolf", true));
        }

        public Diersoort SelecteerDiersoort(string naam)
        {
            return diersoorten[naam];
        }
    }
}
