using Abc.core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Abc.Northwind.Entities.Concrete
{
    public class Product : IEntity
    {  [Required]
        public int ProductId { get; set; }
        [Required]
        [Display(Name ="Product Name")]
        public string  ProductName { get; set; }
        [Required]
        [Display(Name ="Category")]
        public int CategoryId { get; set; }
        [Required]
        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }
       [Required] 
        [Display(Name = "Units In Stock")]
        public short UnitsInStock { get; set; }

    }
}
