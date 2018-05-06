using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace LAB5_Nlog
{
    [Developer("Максим", "Алексеевич", "Зёмов")]
    class Program
    {
        

        static void Main(string[] args)
        {
            Nlog log = new Nlog();
            log.Zapuskprograms();
            GetAttribute(typeof(Program));
            OOP deistv = new OOP();
            deistv.Zapusk();
            Kollekcii kol = new Kollekcii();
            kol.Collection();
            log.Closeprogram();
        }

        public static void GetAttribute(Type g)
        {
            DeveloperAttribute attribute = (DeveloperAttribute)Attribute.GetCustomAttribute(g, typeof(DeveloperAttribute));
            Console.WriteLine("Имя: {0}", attribute.Firstname);
            Console.WriteLine("Отчество: {0}", attribute.Patronymic);
            Console.WriteLine("Фамилия: {0}", attribute.Lastname);

        }
    }
}
