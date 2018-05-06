using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_Kollekcii
{
    class Smartphone : Mobile
    {
        protected string OS;
        protected string Country;

        public Smartphone(string os, string country, string nazvanie, int cena) : base(nazvanie, cena)
        {
            this.OS = os;
            this.Country = country;
        }
        public override string Info()
        {
            return Country + " " + OS + " " + Nazvanie + " " + Cena;
        }
    }
}
