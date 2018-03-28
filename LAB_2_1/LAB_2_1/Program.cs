using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_1
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Консольный калькулятор (бета-версия 1.0)");
            Console.WriteLine(' ');
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"Выберите арифметическое действие:
            - Умножение (введите 1)
            - Деление (введите 2)
            - Сложение (введите 3)
            - Вычитание (введите 4)
            - Возведение числа в степень (введите 5)");
            Class1 c = new Class1();
            Console.ForegroundColor = ConsoleColor.Red;
            c.q = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введите первое значение");
            Console.ForegroundColor = ConsoleColor.Red;
            c.a = double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введите второе значение");
            Console.ForegroundColor = ConsoleColor.Red;
            c.b = double.Parse(Console.ReadLine());
            Console.WriteLine(' ');
            c.Metod();
        }
    }
}
