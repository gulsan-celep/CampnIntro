using System;

namespace MusteriTakip
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1111;
            customer1.customerName = "Gülşan";
            customer1.customerSurname = "Celep";
            customer1.email = "test@test.com";
            customer1.old = 23;

            CustomerManager cm = new CustomerManager();
            cm.customerAdd(customer1);
            cm.customerList(customer1);
            cm.customerRemove(customer1);
        }
    }
}
