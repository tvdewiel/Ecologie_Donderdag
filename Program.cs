using Ecologie_Donderdag.Beheerders;
using Ecologie_Donderdag.Domein;

namespace Ecologie_Donderdag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //AnderstaligeNaam vosEngels = new AnderstaligeNaam("Fox","Engels");

            //Diersoort vos=new Diersoort("Vos","wet vos",true);
            //vos.VoegNaamToe(vosEngels);

            //Console.WriteLine($"{vos}");


            ////uc : registreer natuurgebied
            //Console.WriteLine("Geef id:");
            //string id=Console.ReadLine();
            //Console.WriteLine("geef naam:");
            //string  naam=Console.ReadLine();
            //Console.WriteLine("geef locatie:");
            //string locatie=Console.ReadLine();
            //Console.WriteLine("geef oppervlakte:");
            //float oppervlakte=float.Parse(Console.ReadLine());

            //NatuurBeheerder natuurBeheerder=new NatuurBeheerder();
            //natuurBeheerder.RegistreerNatuurgebied(id,locatie,naam,oppervlakte);


            //UC : registreer waarneming
            NatuurBeheerder natuurBeheerder=new NatuurBeheerder();
            Natuurgebied natuurgebied= natuurBeheerder.SelecteerNatuurgebied("A1");

            DiersoortBeheerder diersoortBeheerder=new DiersoortBeheerder();
            Diersoort diersoort= diersoortBeheerder.SelecteerDiersoort("vos");

            OnderzoekerBeheerder onderzoekerBeheerder=new OnderzoekerBeheerder();
            Onderzoeker onderzoeker = onderzoekerBeheerder.SelecteerOnderzoeker(1);

            Console.WriteLine("Geef aantal:");
            int aantal=int.Parse(Console.ReadLine());
            DateTime datum=DateTime.Now;

            WaarnemingBeheerder waarnemingBeheerder=new WaarnemingBeheerder();
            Waarneming waarneming=waarnemingBeheerder.RegistreerWaarneming(aantal, datum,diersoort,onderzoeker,natuurgebied);

            Console.WriteLine("einde uc");
        }
    }
}
