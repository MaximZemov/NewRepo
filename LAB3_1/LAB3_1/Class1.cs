using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Class1 : Interface1
    {
        double x, d;

        public Class1(double x, double d)
        {
            this.d = d;
            this.x = x;
        }

        double Interface1.ploshad()
        {
            return d * x;
        }

        double Interface1.summa()
        {
            return d + x;
        }

    }
}