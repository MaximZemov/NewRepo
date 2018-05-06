using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_Kollekcii
{
    public class OOP
    {
        public void Zapusk()
        {
            Samsung phone_2 = new Samsung("3100 mA", "Samsung", "Android 7.1", "Корея", "Galaxy J7", 18500);
            Console.WriteLine(phone_2.Info());
            Xiaomi phone_1 = new Xiaomi("Xiaomi", "3000 mA", "Android 7.0", "Китай", "Redmi note 4", 11000);
            Console.WriteLine(phone_1.Info());
            Console.ReadLine();
        }
    }
}
