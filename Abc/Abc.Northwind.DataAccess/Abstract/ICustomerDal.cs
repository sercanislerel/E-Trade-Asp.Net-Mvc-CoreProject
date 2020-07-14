using Abc.core.DataAccess;
using Abc.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Northwind.DataAccess.Abstract
{
  public  interface ICustomerDal : IEntityRepository<Customer>
    {
    }
}
