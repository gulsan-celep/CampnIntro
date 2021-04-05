using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriTakip
{
    class CustomerManager
    {
        public void customerAdd(Customer customer)
        {
            Console.WriteLine("Id: " +customer.Id.ToString() + "  Name: " +customer.customerName+ " Surname: " +customer.customerSurname+ " email: "+customer.email+ " Yaş: "+customer.old.ToString()+ " customer eklendi.");
        }

        public void customerList(Customer customer)
        {
            Console.WriteLine("Id: " + customer.Id.ToString() + "  Name: " + customer.customerName + " Surname: " + customer.customerSurname + " email: " + customer.email + " Yaş: " + customer.old.ToString() + " customer listelendi.");
        }

        public void customerRemove(Customer customer)
        {
            Console.WriteLine("Id: " + customer.Id.ToString() + "  Name: " + customer.customerName + " Surname: " + customer.customerSurname + " email: " + customer.email + " Yaş: " + customer.old.ToString() + " customer silindi.");
        }
    }
}
