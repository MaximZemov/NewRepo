using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_1
{
    public class Class1
    {
        public string q;
        public double a, b;

        public void Metod()
        {
           if (q == "1")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Результат умножения = {0}", a * b);
            }
            if (q == "2")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Результат деления = {0}", a / b);
            }
            if (q == "3")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Результат сложения = {0}", a + b);
            }
            if (q == "4")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Результат вычитания = {0}", a - b);
            }
            if (q == "5")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Результат возведения числа в степень = {0}", Math.Pow(a, b));
            }
            Console.ReadKey();
        }
    }
}
