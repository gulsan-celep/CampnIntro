using System;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> myDictionary = new Odev2.MyDictionary<string>();
            myDictionary.Add("Gulsan");

            Console.WriteLine(myDictionary.itemListLength.ToString());

            foreach (var item in myDictionary.items)
            {
                Console.WriteLine(item);
            }

            myDictionary.Add("Durkadın");

            for (int i = 0; i < myDictionary.items.Length; i++)
            {
                Console.WriteLine(myDictionary.items[i]);
            }

            myDictionary.Add("Ali");
            myDictionary.Add("Ayşe");

            foreach (var item in myDictionary.items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
