using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB5_Nlog
{
    public class Nlog
    {
        private static Logger logirovanie = LogManager.GetCurrentClassLogger();

        public void Zapuskprograms()
        {
            logirovanie.Info("Запуск программы.");
        }

        public void Closeprogram()
        {
            logirovanie.Info("Закрытие программы.");
        }

        public void Cifrs()
        {
            logirovanie.Error("Произошел ввод не чисел!");
        }
    }
}
