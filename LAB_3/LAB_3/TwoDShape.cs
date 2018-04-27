using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    class TwoDShape
    {
        double pri_width;
        double pri_height;
        // Конструктор, используемый по умолчанию, 
        public TwoDShape()
        {
            Width = Height = 0.0;
        }
        // Конструктор для класса TwoDShape. 
        public TwoDShape(double w, double h)
        {
            Width = w;
            Height = h;
        }
        // Сконструировать объект равной ширины и высоты, 
        public TwoDShape(double x)
        {
            Width = Height = x;
        }
        // Свойства ширины и высоты объекта, 
        public double Width
        {
            get { return pri_width; }
            set { pri_width = value < 0 ? -value : value; }
        }
        public double Height
        {
            get { return pri_height; }
            set { pri_height = value < 0 ? -value : value; }
        }
        public void ShowDim()
        {
            Console.WriteLine("Ширина и высота равны " +
                  Width + " и " + Height);
        }
    }
}
