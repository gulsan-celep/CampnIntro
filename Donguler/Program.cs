using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] { "Kurs1", "Kurs2", "Kurs3", "Kurs4" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string item in kurslar)
            {
                Console.WriteLine(item);
            }

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
