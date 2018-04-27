using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kollekcii
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> countries = new List<string>() { "Россия", "США", "Великобритания", "Китай" };
            foreach (string s in countries)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Введите название еще одной страны для добавленияв коллекцию");
            string n = Console.ReadLine();
            countries.Add(""+n+"");
            Console.WriteLine("Введите номер элемента, который необходимо удалить:");
            int t = int.Parse(Console.ReadLine());
            countries.RemoveAt(t-1); // удаление второго элемента
            foreach (string а in countries)
            {
                Console.WriteLine(а);
            }
            Console.WriteLine();
            Console.ReadLine();
            // необобщенная коллекция ArrayList
            Console.WriteLine("Создадим еще 1 коллекцию");
            Console.ReadLine();
            ArrayList objectList = new ArrayList() {};
            object obj = 45.8;

            objectList.Add(obj);
            objectList.Add(152);
            objectList.Add("Элемент");
            objectList.Add(8545);
            objectList.Add("string2");
            objectList.Add("Новое знчение");
            foreach (object o in objectList)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("Cейчас будет удален 1 элемент коллекции. Для продолжения нажи на любую клавишу");
            Console.ReadLine();
            objectList.RemoveAt(0); // удаление первого элемента
            foreach (object o in objectList)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("Общее число элементов коллекции: {0}", objectList.Count);
            Console.ReadLine();
        }
    }
}
