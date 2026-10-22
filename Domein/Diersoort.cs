using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecologie_Donderdag.Domein
{
    public class Diersoort
    {
        public Diersoort(string nederlandseNaam, string wetenschappelijkeNaam, bool isBedreigd)
        {
            NederlandseNaam = nederlandseNaam;
            WetenschappelijkeNaam = wetenschappelijkeNaam;
            IsBedreigd = isBedreigd;
        }

        public string NederlandseNaam { get; set; }
        public string WetenschappelijkeNaam {  get; set; }
        public bool IsBedreigd {  get; set; }

        private List<AnderstaligeNaam> _namen = new();
        public IReadOnlyList<AnderstaligeNaam> Namen() { return _namen; }

        public void VoegNaamToe(AnderstaligeNaam naam)
        {
            //logica voor checks
            _namen.Add(naam);
        }

        public override string ToString()
        {
            return $"Mijn naam is {NederlandseNaam},{WetenschappelijkeNaam} en ik ben bedreigd : {IsBedreigd}";
        }
    }
}
