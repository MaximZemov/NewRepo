using GeometricFigures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests1
{
    [TestFixture]
    public class Proverki
    {
        [Test]
        public void TriangleAreaFull()
        {
            for (int i = 0; i <= 20; i++)
            {
                for (int j = 0; j <= 20; j++)
                {
                    for (int k = 0; k <= 20; k++)
                    {
                        try
                        {
                            Triangle triangle = new Triangle(i, j, k);
                            double per = 1 / 2 * (i + j + k);
                            double area = Math.Sqrt(per * (per - i) * (per - j) * (per - k));
                            Assert.AreEqual(Math.Round(area, 2), Math.Round(triangle.getAreaTriangle(), 2));
                        }
                        catch
                        {
                            Console.WriteLine("Ошибка данных ( {0} ,{1}, {2} ) ", i, j, k);
                        }

                    }

                }

            }
        }

        [Test]
        public void TriangleLenghtFull()
        {

            for (int i = 0; i <= 20; i++)
            {
                for (int j = 0; j <= 20; j++)
                {
                    for (int k = 0; k <= 20; k++)
                    {
                        try
                        {
                            Triangle triangle = new Triangle(i, j, k);
                            double lenght = i + j + k;
                            Assert.AreEqual(Math.Round(lenght, 2), Math.Round(triangle.getLengthTriangle(), 2));
                        }
                        catch
                        {
                            Console.WriteLine("Ошибка данных ( {0} ,{1}, {2} ) ", i, j, k);
                        }

                    }

                }

            }
        }


        [Test]
        public void CircleLetter()
        {
            Exception exception = null;
            try
            {
                Circle circle = new Circle(Convert.ToInt32("incorrect type"));
            }
            catch (Exception excep)
            {
                exception = excep;
            }
            Assert.IsNull(exception);
        }


        [Test]
        public void CircleWithMines()
        {
            Exception exception = null;
            try
            {
                Circle circle = new Circle(-4);
            }
            catch (Exception excep)
            {
                exception = excep;
            }
            Assert.IsNotNull(exception);
        }

        [Test]
        public void SquareLetter()
        {
            Exception exception = null;
            try
            {
                Square circle = new Square(Convert.ToInt32("incorrect type"));
            }
            catch (Exception excep)
            {
                exception = excep;
            }
            Assert.IsNull(exception);
        }


        [Test]
        public void SquareWithMines()
        {
            Exception exception = null;
            try
            {
                Square circle = new Square(-4);
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            Assert.IsNotNull(exception);
        }
        [Test]
        public void TriangleLetter()
        {
            Exception exception = null;
            try
            {
                Triangle circle = new Triangle(Convert.ToInt32("incorrect type"), Convert.ToInt32("incorrect type"), Convert.ToInt32("incorrect type"));
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNull(exception);
        }


        [Test]
        public void TriangleWithMines()
        {
            Exception exception = null;
            try
            {
                Triangle circle = new Triangle(-2, -2, -2);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
    }
}
