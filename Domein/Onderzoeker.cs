using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecologie_Donderdag.Domein
{
    public class Onderzoeker
    {
        public Onderzoeker(string naam, string email, int id)
        {
            Naam = naam;
            Email = email;
            Id = id;
        }

        public string Naam {  get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
    }
}
