using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] {"Engin", "Murat", "Kerem", "Halil" };

            Console.WriteLine(isimler[0]);
            //isimler[4] = "İlker";

            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]); // Değer dönmez çünkü new diyip yeniden tanımladın. O yüzden yeni bellek tanımlandı.

            // Toplu comment alma ctrl K + ctrl C geri alma ctrl k + ctrl u
            //List<string> isimler2 = new List<string>();
            //isimler2.Add("Engin");

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);




        }
    }
}
