using Abc.Northwind.Entities.Concrete;
using Abc.Northwind.MvcUI.Models;
using Abc.Northwind.MvcUI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.Northwind.MvcUI.ViewComponents
{
    public class CartSummaryViewComponent :ViewComponent
    {
        private ICartSessionService _cartSessionService;

        public CartSummaryViewComponent( ICartSessionService cartSessionService)
        {
            _cartSessionService = cartSessionService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new CartSummaryViewModel()
            {
                Cart = _cartSessionService.GetCart()
        };
            return View(model);
      



        }
    }
}
