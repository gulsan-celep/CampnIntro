using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer {DateOfBirth=new DateTime(1997,10,11), FirstName="Gülşan", LastName="Celep", Id=1, NationalityId="1234"});

        }
    }

}
