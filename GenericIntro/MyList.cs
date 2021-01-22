using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<Tp>
    {
        Tp[] items;
        public MyList()
        {
            items = new Tp[0];
        }

        public void Ekle(Tp Eleman)
        {
            Tp[] GeciciDizi = items;
            items = new Tp[items.Length + 1];

            for (int i = 0; i < GeciciDizi.Length; i++)
            {
                items[i] = GeciciDizi[i];
            }
            items[items.Length - 1] = Eleman;
        }
    }
}
