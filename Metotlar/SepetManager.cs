using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    public class SepetManager
    {
        // naming convention -> Adlandırma function ismi Ekle() ilk harfi büyük olmalı
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler, sepete Eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string detay, int fiyat)
        {
            Console.WriteLine("Tebrikler, sepete Eklendi : " + urunAdi);
        }
    }
}
