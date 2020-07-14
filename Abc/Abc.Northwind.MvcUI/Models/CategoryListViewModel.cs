using Abc.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.Northwind.MvcUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get;  set; }
        public int CurrentCategory { get;  set; }
    }
}
