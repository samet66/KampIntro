using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class UrunYonetimi
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine(urun.UrunAdi + " Eklendi.");
        }

        public void Guncelle(Urun urun)
        {
            Console.WriteLine("Güncellendi");
        }
    }
}
