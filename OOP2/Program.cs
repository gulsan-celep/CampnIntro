using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri = new GercekMusteri();
            musteri.Id = 1;
            musteri.MusteriNo = "23361";
            musteri.Adi = "Engin";
            musteri.Soyadi = "Demiroğ";
            musteri.TcNo = "145789441";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "145236";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "14523698";

            Customer musteri3 = new GercekMusteri();
            Customer musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri);
            customerManager.Add(musteri2);
            customerManager.Add(musteri3);
        }
    }
}
