using Abc.Northwind.Business.Abstract;
using Abc.Northwind.Entities.Concrete;
using Abc.Northwind.MvcUI.Models;
using Abc.Northwind.MvcUI.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.Northwind.MvcUI.Controllers
{
    public class CartController : Controller
    {
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;
        private ICustomerService _customerService;

        public CartController(ICartSessionService cartSessionService,
            ICartService cartService,
            IProductService productService,
            ICustomerService customerService
            )
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
            _customerService = customerService;
        }

        public ActionResult AddToCart(int productId)
        {
            var productToBeAdded = _productService.GetById(productId);
            var cart = _cartSessionService.GetCart();
            _cartService.AddToCart(cart, productToBeAdded);
            _cartSessionService.SetCart(cart);
            TempData.Add("message", String.Format("Your Product, ' {0} ', was successfully added to the cart", productToBeAdded.ProductName));
            return RedirectToAction("Index", "Product");
        }
        public ActionResult List()
        {
            var cart = _cartSessionService.GetCart();

            CartSummaryViewModel cartSummaryViewModel = new CartSummaryViewModel() { Cart = cart };
            return View(cartSummaryViewModel);

        }

        public ActionResult Remove(int productId)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveFromCart(cart, productId);
            _cartSessionService.SetCart(cart);
            TempData.Add("message", String.Format("Your Product  was successfully deleted from the cart"));
            return RedirectToAction("List", "Cart");
        }
        public ActionResult Complete()
        {
            var customerDetailsViewModel = new CustomerDetailsViewModel()
            {
                Customer = new Customer(),
            };
            return View(customerDetailsViewModel);
        }
        [HttpPost]
        public ActionResult Complete(Customer customer)
        {
           

            if (ModelState.IsValid)
            {
                _customerService.Add(customer);
                TempData.Add("message", String.Format("thank you {0}, your order is on process ", customer.ContactName));
                return RedirectToAction("Index", "Product");

            }

            return View();


        }
        public ActionResult QuantityDescent(int productId)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.QuantityDescent(cart, productId);
            _cartSessionService.SetCart(cart);
            return RedirectToAction("List", "Cart");
        }

        public ActionResult QuantityIncrese(int productId)
        {

            var cart = _cartSessionService.GetCart();
            _cartService.QuantityIncrese(cart, productId);
            _cartSessionService.SetCart(cart);
            return RedirectToAction("List", "Cart");
        }





    }
}

