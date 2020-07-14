using Abc.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace Abc.Northwind.MvcUI.Models
{
    public class CustomerListViewModel
    {
        public CustomerListViewModel()
        {

        }
       
        public List<Customer> Customers { get; set; }
    }
}