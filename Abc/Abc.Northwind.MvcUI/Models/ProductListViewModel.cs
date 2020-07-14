using Abc.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.Northwind.MvcUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
        public Product Product { get; set; }
        public int CurrentPage { get; internal set; }
        public int CurrentCategory { get; internal set; }
        public int PageSize { get; internal set; }
        public int PageCount { get; internal set; }
        public string Key { get; set; }
    }
}
