using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urunler urun1 = new Urunler
            {
                Id = 1,
                UrunAdi = "Elma",
                Fiyat = 2.5,
                Aciklama = "1kg Köy elması"
            };

            Urunler urun2 = new Urunler
            {
                Id = 2,
                UrunAdi = "Karpuz",
                Fiyat = 56.5,
                Aciklama = "1KG karpuz"
            };

            Urunler urun3 = new Urunler
            {
                Id = 3,
                UrunAdi = "Muz",
                Fiyat = 12,
                Aciklama = "Yerli muz"
            };


            Urunler[] urun = new Urunler[]
            {
                urun1,urun2,urun3
            };
            

            foreach (Urunler item in urun)
            {
                Console.WriteLine(
                    item.UrunAdi + "\n" +
                    item.Fiyat + "\n" +
                    item.Aciklama + "\n......................"
                    );
            }


            Console.WriteLine("\n\n\n.................................Metotlar.............................");

            SepetIslemleri sepet = new SepetIslemleri();
            sepet.Ekle(urun1);
            sepet.Ekle(urun2);
            sepet.Ekle(urun3);
            



            Console.ReadLine();
        }
    }
}
