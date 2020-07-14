using Abc.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace Abc.Northwind.MvcUI.Models
{
    public class ProductPopularViewModel
    {
        public List<Product> Products { get; internal set; }
    }
}