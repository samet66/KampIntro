using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruYonetimi
    {
        public void BasvuruYap(IKrediBaseManager KT, ILoggerService logger)
        {
            //KonutKrediYonetici krediYonetici = new KonutKrediYonetici();
            //krediYonetici.Hesapla();

            KT.Hesapla();
            logger.Log();
        }
        public void KrediOnBilgilendirme(List<IKrediBaseManager> Krediler)
        {
            foreach (var item in Krediler)
            {
                item.Hesapla();
            }
        }
    }
}
