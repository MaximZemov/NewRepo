using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_Nlog
{
    abstract class Mobile : IComparable
    {
        protected string Nazvanie;
        public int Cena;

        protected Mobile(string nazvanie, int cena)
        {
            Nazvanie = nazvanie;
            Cena = cena;
        }

        public int CompareTo(object obj)
        {
            var mobile = (Mobile)obj;
            return Cena - mobile.Cena;
        }

        public abstract string Info();

        public void Print()
        {
            Console.WriteLine(Info());

        }

    }
}
