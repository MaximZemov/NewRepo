using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_1
{
    class Program
    {
        static char k = 'д';

        static void Main(string[] args)
        {
            Class1 c = new Class1();
            c.Hi();
            while (k == 'д')
            {
                c.Vvod();
                c.Metod();
                Console.WriteLine("Продолжить работу? (да/нет)");
                k = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
