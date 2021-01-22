using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string kurs1 = "Yetiştirme kampu",
                   kurs2 = "Programlamaya başlangıç için temel kurs",
                   kurs3 = "Java kursu";
            */
            
            string[] kurslar = new string[] 
            { "Yetiştirme kampu",
              "Programlamaya başlangıç için temel kurs",
              "Java kursu",
              "Python kursu"
            };


            for (int i = 0; i < kurslar.Length; i++) //dizini uzunluğu lenght
            {
                Console.WriteLine(kurslar[i]);// dizi elemanı 0dan başlar i=0 , i=1 ...
            }

            Console.WriteLine("\nFor bitti\n");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.ReadLine();
        }
    }
}
