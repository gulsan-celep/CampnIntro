using System;
using System.Collections.Generic;
using System.Text;

namespace Odev3
{
    class BlackFridaySalesManager : ISalesService
    {
        public void Discount(Game game)
        {
            Console.WriteLine("Oyun %5 indirime girdi");
        }
    }
}
