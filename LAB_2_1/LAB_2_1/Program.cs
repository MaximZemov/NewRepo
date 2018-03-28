using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"Выберите арифметическое действие:
            - Умножение (введите 1)
            - Деление (введите 2)
            - Сложение (введите 3)
            - Вычитание (введите 4)
            - Возведение числа в степень (введите 5)");
            Console.ForegroundColor = ConsoleColor.Red;
            string q = Console.ReadLine();
            double a, b;
            Console.WriteLine(' ');
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введите первое значение");
            Console.ForegroundColor = ConsoleColor.Red;
            a = double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введите второе значение");
            Console.ForegroundColor = ConsoleColor.Red;
            b = double.Parse(Console.ReadLine());
            Console.WriteLine(' ');

            static 
                { }
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
