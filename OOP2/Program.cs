using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri = new GercekMusteri();
            musteri.MusteriNo = "1212";
            musteri.MusAdi = "SAmet";
            musteri.MusteriSoyadi = "Sahingoz";
            musteri.TCNO = "1234596853";

            TuzelMusteri Tmusteri = new TuzelMusteri();
            Tmusteri.Id = 1;
            Tmusteri.MusteriNo = "123";
            Tmusteri.SirketAdi = "Kodlama.io";
            Tmusteri.VergiNo = "2352424234";

            Console.WriteLine("Hello World!");


            Musteri musteri2 = new GercekMusteri();
            Musteri musteri3 = new TuzelMusteri();

            MusteriYonetim musY = new MusteriYonetim();
            musY.Ekle(musteri);
        }
    }
}
