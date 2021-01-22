using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Samet", "Halil" };
            //Console.WriteLine(isimler[0]);

            List<string> isimler = new List<string> {"Engin", "Samet"};
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);

            isimler.Add("Metin");

            Console.WriteLine(isimler[2]);

            Console.ReadLine();
        }
    }
}
