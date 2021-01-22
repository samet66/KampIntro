using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediBaseManager ıhtiyacKredi = new IhtiyacKrediYaonetici();
            IKrediBaseManager tasitKredi = new TasitKrediYonetici();
            IKrediBaseManager konutKredi = new KonutKrediYonetici();

            ILoggerService DataLog = new DataBaseLog();
            ILoggerService FileLog = new FileLog();

            BasvuruYonetimi basvuruYonetimi = new BasvuruYonetimi();
            basvuruYonetimi.BasvuruYap(konutKredi,DataLog);
            Console.WriteLine("Hello!");

            List<IKrediBaseManager> krediler = new List<IKrediBaseManager>() 
            {
                ıhtiyacKredi,tasitKredi
            };
            //basvuruYonetimi.KrediOnBilgilendirme(krediler);
        }
    }
}
