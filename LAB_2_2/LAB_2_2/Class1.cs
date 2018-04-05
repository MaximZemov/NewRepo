using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_2
{
    public class Class1
    {
         public void Privet()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Калькулятор сложения 2-х массивов");
        }

        public void Vvod()
        {
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Введите 1 массив");
            int [,] arr1 = Massiv();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Введите 2 массив");
            int [,] arr2 = Massiv();
            int [,] arr3 = Sum(arr1, arr2);            
        }


        public int [,] Massiv()
        {
            Console.WriteLine("Введите число элементов по вертикали:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число элементов по горизонтали:");
            int t = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, t];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    Console.Write("Введите arr1[{" + i + "},{" + j + "}] : ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return arr;
        }

        public  int[,] Sum(int[,] mas1, int[,] mas2)
        {

            int n1 = mas1.GetLength(0);
            int n2 = mas2.GetLength(0);
            int t1 = mas1.GetLength(1);
            int t2 = mas2.GetLength(1);

            int n = Math.Max(n1, n2);
            int t = Math.Max(t1, t2);
            int[,] summa = new int[n, t];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    summa[i, j] = mas1[i,j] + mas2[i, j];
                    Console.WriteLine(summa[i,j]);
                }
            }
           return summa;
        }

     }
}
