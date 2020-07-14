using Abc.Northwind.Business.Abstract;
using Abc.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abc.Northwind.Business.Concrete
{
    public class CartService : ICartService
    {
        public void AddToCart(Cart cart, Product producT)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(c => c.product.ProductId == producT.ProductId);
            if (cartLine != null)
            {
                cartLine.Quantity++;
                return;
            }
            cart.CartLines.Add(new CartLine { product = producT, Quantity = 1 });
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }

        public void RemoveFromCart(Cart cart, int productId)
        {

            cart.CartLines.Remove(cart.CartLines.FirstOrDefault(c => c.product.ProductId == productId));

        }



        public void QuantityIncrese(Cart cart, int productId)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(c => c.product.ProductId == productId);

            if (cartLine.Quantity < cartLine.product.UnitsInStock)
            {
                cartLine.Quantity++;
            }



        }

        public void QuantityDescent(Cart cart, int productId)
        {

            CartLine cartLine = cart.CartLines.FirstOrDefault(c => c.product.ProductId == productId);
            if (cartLine.Quantity > 1)
            {
                cartLine.Quantity--;
            }
        }
    }
}
