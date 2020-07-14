using Abc.Northwind.Business.Abstract;
using Abc.Northwind.MvcUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.Northwind.MvcUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;


        }
        public ActionResult Index(int page = 1, int category = 0)
        {
            int pageSize = 15;
            var products = _productService.GetByCategory(category);
            ProductListViewModel model = new ProductListViewModel()
            {    
                Products = products.Skip((page - 1) * pageSize).Take(pageSize).ToList(),

               
                PageCount = (int)Math.Ceiling(products.Count / (double)pageSize),
                PageSize = pageSize,
                CurrentCategory = category,
                CurrentPage = page

            };

            return View(model);
        }
        [HttpPost]
        public ActionResult Index(string key, int page = 1, int category = 0)
        {
            int pageSize = 12;
            var products = _productService.GetByName(key);
            ProductListViewModel model = new ProductListViewModel()
            {     
                Products = products.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                Key = key,

              
                PageCount = (int)Math.Ceiling(products.Count / (double)pageSize),
                PageSize = pageSize,
                CurrentCategory = category,
                CurrentPage = page

            };

            return View(model);
        }


        public ActionResult Popular()
        {
            short stockAmount = 7;
            ProductPopularViewModel model = new ProductPopularViewModel()
            {
                Products = _productService.GetByStockAmount(stockAmount),

            };


            return View(model);


        }
        public ActionResult Minprice(int page = 1)
        {
            int pageSize = 15;
            var products = _productService.GetMinByPrice();
            ProductFilterViewModel model = new ProductFilterViewModel()
            {
                MinProducts =  products.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                
            };
            return View(model);
        }

        public ActionResult Maxprice(int page=1)
        {
            int pageSize = 15;
            var products = _productService.GetMaxByPrice();

            ProductFilterViewModel model = new ProductFilterViewModel()
            {
                MaxProducts = products.Skip((page - 1) * pageSize).Take(pageSize).ToList(),

            };
            return View(model);
        }

        public ActionResult Filters()
        {
            return View();
        }




    }
}
