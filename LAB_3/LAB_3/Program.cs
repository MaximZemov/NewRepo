using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    class Program
    {
        static void Main()
        {
            Collections();
            ColorTriangle t1 =
                 new ColorTriangle("синий", "прямоугольный", 8, 12);
            ColorTriangle t2 =
                 new ColorTriangle("красный", "равнобедренный", 2, 2);
            Console.WriteLine("Сведения об объекте t1: ");
            t1.ShowStyle();
            t1.ShowDim();
            t1.ShowColor();
            Console.WriteLine("Площадь равна " + t1.Area());
            Console.WriteLine();
            Console.WriteLine("Сведения об объекте t2: ");
            t2.ShowStyle();
            t2.ShowDim();
            t2.ShowColor();
            Console.WriteLine("Площадь равна " + t2.Area());
        }

        protected static void Collections()
        {
            ColorTriangle t2 = new ColorTriangle("красный", "равнобедренный", 2, 2);
            ColorTriangle t1 = new ColorTriangle("синий", "прямоугольный", 8, 12);
            List<ColorTriangle> objList = new List<ColorTriangle>();
            objList.Add(t1);
            objList.Add(t2);
            objList.Sort(); //сортировка
            objList.ForEach(t => t.ShowColor());
            Console.ReadLine();
        }
    }

}
