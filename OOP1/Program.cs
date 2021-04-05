using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 115;
            product1.UnitInStock = 10;

            Product product2 = new Product { Id = 2, CategoryId = 3, ProductName="Kalem", UnitInStock=2, UnitPrice=5 };

            //PascalCase ->ProductManager ClassName   //camelCase -> productManager değişken ismi dikkat et.
            // case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
