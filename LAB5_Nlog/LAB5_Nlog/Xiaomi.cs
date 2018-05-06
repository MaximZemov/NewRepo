using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_Nlog
{
    class Xiaomi : Smartphone
    {
        protected string Brend;
        protected string Batery;

        public Xiaomi(string brend, string batery, string os, string country, string nazvanie, int cena) : base(os, country, nazvanie, cena)
        {
            this.Brend = brend;
            this.Batery = batery;
        }

        public override string Info()
        {
            return "Бренд - " + Brend + ", ёмкость батареи - " + Batery + ", ОС  - " + OS + ", страна производитель - " + Country + ", название модели - " + Nazvanie + ", цена - " + Cena;
        }
    }
}
