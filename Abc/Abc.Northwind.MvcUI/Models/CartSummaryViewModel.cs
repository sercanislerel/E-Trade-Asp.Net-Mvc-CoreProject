using Abc.Northwind.Entities.Concrete;

namespace Abc.Northwind.MvcUI.Models
{
    public class CartSummaryViewModel
    {
      
        public Cart Cart { get; set; }
        public CartLine CartLine { get; set; }
    }
}