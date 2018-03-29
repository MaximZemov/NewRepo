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

       
        public void Massiv1()
        {
            int[,] arr1 = new int[n, t];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    Console.Write("Введите arr1[{" + i + "},{" + j + "}] : ");
                    arr1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine(" ");
        }

        public void Massiv2()
        {
            int[,] arr2 = new int [n,t];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    Console.Write("Введите arr[{" + i + "},{" + j + "}] : ");
                    arr2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.ReadLine();
        }

    }
}
