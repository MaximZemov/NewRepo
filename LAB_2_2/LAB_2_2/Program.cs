using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_2
{
    class Program
    {
        static int k = 1;

        static void Main(string[] args)
        {
            Class1 c = new Class1();
            c.Privet();
            while (k == 1)
            {
                c.Vvod();
                Console.WriteLine("Произвести сложение еще 2 массивов? (1- да/ 2- нет)");
                k = Convert.ToInt32 (Console.ReadLine());
            }
        }
    }
}
