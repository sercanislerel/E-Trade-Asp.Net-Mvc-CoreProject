using Abc.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.Northwind.MvcUI.Models
{
    public class ProductAddViewModel
    {

        public Product Product { get; set; }
        public List<Category> Category { get; internal set; }
    }
}
