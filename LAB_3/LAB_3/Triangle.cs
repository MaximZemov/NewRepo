using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    class Triangle : TwoDShape
    {
        string Style; // закрытый член класса
                      /* Конструктор, используемый по умолчанию. Автоматически вызывает конструктор, доступный по умолчанию в классе TwoDShape. */
        public Triangle()
        {
            Style = "null";
        }
        // Конструктор.
        public Triangle(string s, double w, double h) : base(w, h)
        {
            Style = s;
        }
        // Сконструировать равнобедренный треугольник, 
        public Triangle(double x) : base(x)
        {
            Style = "равнобедренный";
        }
        // Возвратить площадь треугольника, 
        public double Area()
        {
            return Width * Height / 2;
        }
        // Показать тип треугольника, 
        public void ShowStyle()
        {
            Console.WriteLine("Треугольник " + Style);
        }
    }
}
