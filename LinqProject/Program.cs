using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Product> products = TestMethod();
            //            GetProducts(products);


            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Bilgisayar"},
                new Category{CategoryId=2, CategoryName="Telefon"},
            };
            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Acer Laptop", QuantityPerUnit="32 GB Ram", UnitPrice=10000, UnitInStock=5},
                new Product{ProductId=2, CategoryId=1, ProductName="Asus Laptop", QuantityPerUnit="16 GB Ram", UnitPrice=8000, UnitInStock=3},
                new Product{ProductId=3, CategoryId=1, ProductName="Hp Laptop", QuantityPerUnit="8 GB Ram", UnitPrice=6000, UnitInStock=2},
                new Product{ProductId=4, CategoryId=2, ProductName="Samsung Laptop", QuantityPerUnit="4 GB Ram", UnitPrice=5000, UnitInStock=15},
                new Product{ProductId=5, CategoryId=2, ProductName="Apple Laptop", QuantityPerUnit="4 GB Ram", UnitPrice=8000, UnitInStock=0},
            };
            // Listenin için de o eleman var mı onu kontrol eder. Boolean döner
            var result = products.Any(p => p.ProductName == "Acer Laptop");
            Console.WriteLine(result);

            // Listede elemanı bulur ve nesne olarak bize o elemanı döndürür. Eğer eleman yoksa null döner
            var result1 = products.Find(p=>p.ProductId==3);
            Console.WriteLine(result1.ProductName);

            // Contains aradığımız keliyeme uyan bütün elemanları getirir. Liste döndürür
            var result2 = products.FindAll(p => p.ProductName.Contains("top"));

            var result3 = products.Where(p => p.ProductName.Contains("top"));
            var result4 = products.Where(p => p.ProductName.Contains("top")).OrderBy(p=>p.UnitPrice);
            // Eğer fiyatlar eşit ise ThenByDescending product name'e göre filtrele z-a ya sırala desc
            var result5 = products.Where(p => p.ProductName.Contains("top")).OrderBy(p => p.UnitPrice).ThenByDescending(p=>p.ProductName);

            foreach (var product in result3)
            {
                Console.WriteLine(product.ProductName);
            }

            // products -> tablo, liste --- p-> değişken olsun --- select p ise buna uyan bütün elemanları dön
            var result6 = from p in products
                          select p;

            var result7 = from p in products
                          where p.UnitPrice>6000
                          select p;

            var result8 = from p in products
                          where p.UnitPrice > 6000
                          orderby p.UnitPrice descending, p.ProductName ascending
                          select p;

            foreach (var product in result6)
            {
                Console.WriteLine(product.ProductName);
            }

            var result9 = from p in products
                          where p.UnitPrice > 6000
                          orderby p.UnitPrice descending, p.ProductName ascending
                          select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice};
            foreach (var product in result9)
            {
                Console.WriteLine(product.ProductName);
            }

            var result10 = from p in products
                           join c in categories
                           on p.CategoryId equals c.CategoryId
                           select new ProductDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

            foreach (var productDto in result10)
            {
                //Console.WriteLine(productDto.ProductName + " / " +productDto.CategoryName);
                Console.WriteLine("{0} {1}", productDto.ProductName, productDto.CategoryName);
            }

            var result11 = from p in products
                           join c in categories
                           on p.CategoryId equals c.CategoryId
                           where p.UnitPrice > 5000
                           orderby p.UnitPrice descending
                           select new ProductDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

        }

        private static List<Product> TestMethod()
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Bilgisayar"},
                new Category{CategoryId=2, CategoryName="Telefon"},
            };
            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Acer Laptop", QuantityPerUnit="32 GB Ram", UnitPrice=10000, UnitInStock=5},
                new Product{ProductId=2, CategoryId=1, ProductName="Asus Laptop", QuantityPerUnit="16 GB Ram", UnitPrice=8000, UnitInStock=3},
                new Product{ProductId=3, CategoryId=1, ProductName="Hp Laptop", QuantityPerUnit="8 GB Ram", UnitPrice=6000, UnitInStock=2},
                new Product{ProductId=4, CategoryId=2, ProductName="Samsung Laptop", QuantityPerUnit="4 GB Ram", UnitPrice=5000, UnitInStock=15},
                new Product{ProductId=5, CategoryId=2, ProductName="Apple Laptop", QuantityPerUnit="4 GB Ram", UnitPrice=8000, UnitInStock=0},
            };

            Console.WriteLine("Algoritmik------------");
            // Fiyatı 5000 tl üzerinde olanları listele
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }
            }

            Console.WriteLine("LinQ -------------");

            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

            return products;
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProduct = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 3)
                {
                    filteredProduct.Add(product);
                }
            }

            return filteredProduct;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3).ToList();

        }


    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }

    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }

    class ProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string CategoryName { get; set; }

    }
}
