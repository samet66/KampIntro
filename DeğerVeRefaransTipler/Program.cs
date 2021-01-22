using System;

namespace DeğerVeRefaransTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10, sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;    // Deger tip
            Console.WriteLine(sayi1 + sayi2);



            int[] sayi3 = new int[] { 10, 20, 30 };
            int[] sayi4 = new int[] { 100, 200, 300 };   //referans tip
            sayi3 = sayi4;//sadece adres kopyalar değer değişmez adr es sayı4 olur
            sayi4[0] = 999;
             //sayi3 ??     cevap = 999
            Console.ReadLine();
        }
    }
}
