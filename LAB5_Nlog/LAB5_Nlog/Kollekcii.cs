﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_Nlog
{
    public class Kollekcii
    {
        public void Collection()
        {
            int Cena1dev()
            {
                Nlog logir = new Nlog();
                Console.WriteLine("Введите стоимость 1 устройства: ");
                try { return Convert.ToInt32(Console.ReadLine()); }
                catch
                {
                    Console.WriteLine("Error: вводим только числа!");
                    logir.Cifrs();
                    return Cena1dev();
                }
            }

            Xiaomi phone_1 = new Xiaomi("Xiaomi", "3000 mA", "Android 7.0", "Китай", "Redmi note 4", Cena1dev());
            Samsung phone_2 = new Samsung("3100 mA", "Samsung", "Android 7.1", "Корея", "Galaxy J7", 18500);
            List<Mobile> objectList = new List<Mobile>();
            objectList.Add(phone_2);
            objectList.Add(phone_1);
            objectList.Sort((x, y) => x.Cena.CompareTo(y.Cena));
            objectList.ForEach(t => t.Print());
            Console.ReadLine();
        }
    }
}
