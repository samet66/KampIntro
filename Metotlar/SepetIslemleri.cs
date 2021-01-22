using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetIslemleri
    {

        public void Ekle(Urunler urun)
        {
            Console.WriteLine(urun.UrunAdi + " Adlı ürün sepete eklendi!");
        }

        public void Ekle2(string urunAd, int fiyat) 
        {
            Console.WriteLine(urunAd + " " + fiyat);
        }
    }
}
