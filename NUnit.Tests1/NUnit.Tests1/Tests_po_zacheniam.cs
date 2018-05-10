using NUnit.Framework;
using GeometricFigures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NUnit.Tests1
{
    [TestFixture]
    public class Tests_po_zacheniam
    {
        double pi = 3.141593;

        public static object[] GeometricCircleSquare =
       {
                new object[] { 0 },
                new object[] { 1 },
                new object[] { 2 },
                new object[] { 3 },
                new object[] { 4 },
                new object[] { 5 },
                new object[] { 6 },
                new object[] { 7 },
                new object[] { 8 },
                new object[] { 9 },
                new object[] { 10 },
                new object[] { 11 },
                new object[] { 12 },
                new object[] { 13 },
                new object[] { 14 },
                new object[] { 15 },
                new object[] { 16 },
                new object[] { 17 },
                new object[] { 18 },
                new object[] { 19 },
                new object[] { 20 }

        };
        public static object[] GeometricTriangle =
        {
                new object[] { 0, 0, 0 },
                new object[] { 0, 1, 1 },
                new object[] { 1, 1, 0 },
                new object[] { 1, 0, 1 },
                new object[] { 1, 1, 1 },
                new object[] { 7, 9, 12 },
                new object[] { 12, 16, 3 },
                new object[] { 5, 12, 12 },
                new object[] { 19, 16, 13 },
                new object[] { 4, 14, 9 },
                new object[] { 10, 10, 10 },
                new object[] { 20, 20, 20 }
        };

        [Test, TestCaseSource("GeometricCircleSquare")]
        public void CircleArea(int n)
        {
            Circle circle = new Circle(n);
            double area = pi * n * n;
            Assert.AreEqual(Math.Round(area, 1), Math.Round(circle.getAreaCircle(), 1));
        }

        [Test, TestCaseSource("GeometricCircleSquare")]
        public void CircleLenght(int n)
        {
            Circle circle = new Circle(n);
            double lenght = 2 * pi * n;
            Assert.AreEqual(Math.Round(lenght, 1), Math.Round(circle.getLengthCircle(), 1));
        }
        
        [Test, TestCaseSource("GeometricCircleSquare")]
        public void SquareArea(int n)
        {
            Square square = new Square(n);
            double area = n * n;
            Assert.AreEqual(Math.Round(area, 1), Math.Round(square.getAreaSquare(), 1));
        }

        [Test, TestCaseSource("GeometricCircleSquare")]
        public void SquareLenght(int n)
        {
            Square square = new Square(n);
            double lenght = 4 * n;
            Assert.AreEqual(Math.Round(lenght, 2), Math.Round(square.getLengthSquare(), 2));
        }
        
        [Test, TestCaseSource("GeometricTriangle")]
        public void TriangleLenght(int n, int p, int q)
        {
            Triangle triangle = new Triangle(n, p, q);
            double lenght = n + p + q;
            Assert.AreEqual(Math.Round(lenght, 1), Math.Round(triangle.getLengthTriangle(), 1));
        }

        [Test, TestCaseSource("GeometricTriangle")]
        public void TriangleArea(int n, int p, int q)
        {
            Triangle triangle = new Triangle(n, p, q);
            double per =(n + p + q);
            double area = Math.Sqrt(per * (per - n) * (per - p) * (per - q));
            Assert.AreEqual(Math.Round(area, 1), Math.Round(triangle.getAreaTriangle(), 1));
        }
        
    }
}

