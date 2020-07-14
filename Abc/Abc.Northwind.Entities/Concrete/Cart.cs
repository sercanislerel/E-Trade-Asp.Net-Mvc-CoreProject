using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abc.Northwind.Entities.Concrete
{
    public class Cart
    {
        public Cart()
        {
            CartLines = new List<CartLine>();
        }
        public List<CartLine> CartLines { get; set; }
        public CartLine CartLine { get; set; }
        public decimal Total
        {
            get { return CartLines.Sum(c => c.product.UnitPrice * c.Quantity); }
        }
    }
}
