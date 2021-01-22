using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursEgitmeni = "Samet Şahingöz";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++";
            kurs2.KursEgitmeni = "Buse Şahingöz";
            kurs2.IzlenmeOranı = 60;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C";
            kurs3.KursEgitmeni = "Metin Şahingöz";
            kurs3.IzlenmeOranı = 80;

            Kurs[] kurslar = new Kurs[]
            {
                kurs1,
                kurs2,
                kurs3
            };

            foreach (var item in kurslar)
            {
                Console.WriteLine(item.KursAdi + " " +
                    item.KursEgitmeni + " " +
                    item.IzlenmeOranı+"\n");
            }
            Console.ReadLine();
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int IzlenmeOranı { get; set; }

    }
}
