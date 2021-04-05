using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productName = "Apple";
            product1.productDetail = "Green Apple";
            product1.price = 8.5;
            product1.stok = 50;

            Product product2 = new Product();
            product2.productName = "Orange";
            product2.productDetail = "Washington Orange";
            product2.price = 10.5;
            product2.stok = 10;

            Product product3 = new Product();
            product3.productName = "Strawberry";
            product3.productDetail = "Red Strawberry";
            product3.price = 18.5;
            product3.stok = 60;

            Product[] list = new Product[] { product1, product2, product3 };

            Console.WriteLine("##for yapısı kullanarak listeleme## \n");
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine("Product Name: " +list[i].productName + " \t Product Detail: " + list[i].productDetail + " \t Price: " + list[i].price.ToString() + " \t Stok: " + list[i].stok.ToString());
            }

            Console.WriteLine("##foreach yapısı kullanarak listeleme## \n");
            foreach (Product item in list)
            {
                Console.WriteLine("Product Name: " + item.productName + " \t Product Detail: " + item.productDetail + "\t Price: " + item.price.ToString() + " \t Stok: " + item.stok.ToString());
            }

            Console.WriteLine("##while yapısı kullanarak listeleme## \n");
            int j = 0;
            while (j<list.Length)
            {
                Console.WriteLine("Product Name: " + list[j].productName + " \t Product Detail: " + list[j].productDetail + " \t Price: " + list[j].price.ToString() + " \t Stok: " + list[j].stok.ToString());
                j++;
            }
        }
    }
}
