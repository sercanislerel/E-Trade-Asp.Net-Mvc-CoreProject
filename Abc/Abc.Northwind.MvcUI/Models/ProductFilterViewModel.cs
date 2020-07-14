using Abc.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace Abc.Northwind.MvcUI.Models
{
    public class ProductFilterViewModel
    {
        public List<Product> MinProducts { get;  set; }
        public List<Product> MaxProducts { get; internal set; }
        public int PageCount { get; internal set; }
        public int PageSize { get; internal set; }
        public int CurrentPage { get; internal set; }
        public object CurrentCategory { get; internal set; }
    }
}