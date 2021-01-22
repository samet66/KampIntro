using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem islem = new DortIslem();
            islem.Topla(4, 44.44m);
            islem.Topla(123.3213m, 434.44m);


            Console.ReadLine();
        }
    }
}
