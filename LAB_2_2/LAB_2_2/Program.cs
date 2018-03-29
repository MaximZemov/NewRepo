using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность 2-х массивов ");
            Class1 c = new Class1();
            c.n = int.Parse(Console.ReadLine());
            c.t = int.Parse(Console.ReadLine());
            c.Massiv1();
            c.Massiv2();
        }
    }
}
