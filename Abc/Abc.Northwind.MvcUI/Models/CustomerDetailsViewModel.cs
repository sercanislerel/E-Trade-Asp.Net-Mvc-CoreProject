using Abc.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace Abc.Northwind.MvcUI.Models
{
    public class CustomerDetailsViewModel
    {
        public CustomerDetailsViewModel()
        {
        }

        public Customer Customer { get; set; }
        public List<Customer> Customers { get; set; }
    }
}