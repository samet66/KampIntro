using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun Urun1 = new Urun();
            Urun1.Id = 1;
            Urun1.KategoriId = 1;
            Urun1.UrunAdi = "Masa";
            Urun1.BirimFiyati = 115.5;
            Urun1.StokAdeti = 12;

            Urun Urun2 = new Urun() 
            { 
                Id = 2, 
                KategoriId = 5,
                StokAdeti = 3,
                BirimFiyati=43,
                UrunAdi = "Kalem"
            };

            UrunYonetimi Yonetim = new UrunYonetimi();
            Yonetim.Ekle(Urun1);
        }
    }
}
