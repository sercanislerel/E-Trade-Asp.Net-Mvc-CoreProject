using Abc.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Northwind.Business.Abstract
{
  public   interface ICustomerService
    {
        List<Customer> GetAll();
        void Add(Customer customer);

    }
}
