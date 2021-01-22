using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool SistemeGieis = false;

            double dolarDun = 7.05;
            double dolarBugn = 7.50;

            if (dolarDun > dolarBugn)
            {
                Console.WriteLine("Dolar düştü");
            }
            else if (dolarDun < dolarBugn)
            {
                Console.WriteLine("Dolar yüksek");
            }
            else
            {
                Console.WriteLine("aynı");
            }


            if (SistemeGieis == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap");
            }

            Console.ReadLine();
        }
    }
}
