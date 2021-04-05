using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Abstract;

namespace InterfaceAbstractDemo.Concrete
{
    public class CustomerCheckManager : IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
