using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_Nlog
{
    class Samsung : Smartphone
    {
        protected string Brend;
        protected string Batery;

        public Samsung(string brend, string batery, string os, string country, string nazvanie, int cena) : base(os, country, nazvanie, cena)
        {
            this.Brend = brend;
            this.Batery = batery;
        }

        public override string Info()
        {
            return "Ёмкость батареи - " + Batery + "Бренд - " + Brend + ", ОС  - " + OS + ", страна производитель - " + Country + ", название модели - " + Nazvanie + ", цена - " + Cena;
        }
    }
}
