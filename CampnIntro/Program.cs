using System;

namespace CampnIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety = tip güvenliği
            // Do not repeat yourself = Kendini tekrarlama
            // değer tutucu , alias = CategoryEtiketi
            string CategoryEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistememGiris = true;
            double dolarinDun = 7.35;
            double dolarinBugun = 7.45;

            if (dolarinDun > dolarinBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarinDun < dolarinBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            if (sistememGiris == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");    
            }
            Console.WriteLine(CategoryEtiketi);
        }
    }
}
