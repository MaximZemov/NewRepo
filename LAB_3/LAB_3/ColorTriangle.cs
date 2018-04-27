using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    class ColorTriangle : Triangle
    {
        string color;
        public ColorTriangle(string c, string s,
                        double w, double h) : base(s, w, h)
        {
            color = c;
        }
        // Показать цвет треугольника,
        public void ShowColor()
        {
            Console.WriteLine("Цвет " + color);
        }
    }
}
