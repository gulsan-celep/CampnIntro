using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Clean Code - Best Practice
            // cw tab tab console.writeline()

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Detay = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Portakal";
            urun2.Fiyati = 10;
            urun2.Detay = "Washington Portakalı";

            Urun urun3 = new Urun();
            urun3.Adi = "Karpuz";
            urun3.Fiyati = 80;
            urun3.Detay = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            // type safe -> tip güvenliği -> var u = Urun u
            foreach (Urun u in urunler)
            {
                Console.WriteLine("Ürün Adı: " + u.Adi + " Fiyatı : " + u.Fiyati + " Detay: " + u.Detay);
            }

            Console.WriteLine("---------Metotlar-----------");

            // instance -> Class örneği
            SepetManager sepet = new SepetManager();
            sepet.Ekle(urun1);
            sepet.Ekle(urun2);
            sepet.Ekle(urun3);

            sepet.Ekle2("Armut", "Yeşil Armut", 15);

        }
    }
}
