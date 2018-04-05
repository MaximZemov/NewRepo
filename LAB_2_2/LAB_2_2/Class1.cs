using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_2
{
    public class Class1
    {
        public int n;
        public int t;

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
            foreach (var v in arr3)
                Console.WriteLine(v);
            Console.WriteLine("Ты хочешь сложить два новых массива? (д/н)");
        }


        public int [,] Massiv()
        {
            Console.WriteLine("Введите число элементов по вертикали:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число элементов по горизонтали:");
            t = int.Parse(Console.ReadLine());
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

        public static int[,] Sum(int[,] mas1, int[,] mas2)
        {

            int b1 = mas1.GetLength(0);
            int b2 = mas2.GetLength(0);
            int f1 = mas1.GetLength(1);
            int f2 = mas2.GetLength(1);

            int b = Math.Max(b1, b2);
            int f = Math.Max(f1, f2);
            int[,] summa = new int[b, f];
            for (int i = 0; i < b; i++)
                for (int j = 0; j < f; j++)
                {
                    int X = mas1[i, j];
                    int Z = mas2[i, j];
                    summa[i, j] = X + Z;
                }
           return summa;
        }
        public static int[,] Summa(int[,] A, int[,] B)
        {
            int Q1 = A.GetLength(0);
            int Q2 = B.GetLength(0);
            int W1 = A.GetLength(1);
            int W2 = B.GetLength(1);

            int Q = Math.Max(Q1, Q2);
            int W = Math.Max(W1, W2);

            int[,] Resultat = new int[Q, W];
            for (int i = 0; i < Q; i++)
                for (int p = 0; p < W; p++)
                {
                    int X;
                    if (i < Q1 && p < W1) X = A[i, p]; else X = 0;
                    int Z;
                    if (i < Q2 && p < W2) Z = B[i, p]; else Z = 0;

                    Resultat[i, p] = X + Z;
                }

            return Resultat;
        }


    }
}
