using Abc.Northwind.Business.Abstract;
using Abc.Northwind.Entities.Concrete;
using Abc.Northwind.MvcUI.Entities;
using Abc.Northwind.MvcUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.Northwind.MvcUI.Controllers
{
   

    [Authorize(Roles = "Admin")]
    public class AdminController:Controller

    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        private ICustomerService _customerService;
        private RoleManager<CustomIdentityRole> _roleManager;
        private UserManager<CustomIdentityUser> _userManager;

        public AdminController(IProductService productService ,ICategoryService categoryService,ICustomerService customerService, RoleManager<CustomIdentityRole> roleManager, UserManager<CustomIdentityUser> userManager)
        {
            _productService = productService;
            _categoryService = categoryService;
            _customerService = customerService;
            _roleManager = roleManager;
            _userManager = userManager;

        }
        public ActionResult Index()
        {
            var productListViewModel = new ProductListViewModel()
            {
                Products =_productService.GetAll()
            };
            return View(productListViewModel);

        }
        public ActionResult List()
        {
            var model = new CustomerListViewModel()
            {
                Customers = _customerService.GetAll()
            };
            return View(model);

        }
       
        public ActionResult Add()
        {
            var model = new ProductAddViewModel()
            {
                Product = new Product(),
                Category = _categoryService.GetAll()
            };
            
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            if(ModelState.IsValid)
            {
              _productService.Add(product);
            TempData.Add("message", "product was successfully added");
           
            }

            return RedirectToAction("Add");

        }

        public ActionResult Update(int productId)
        {
            var model = new ProductUpdateViewModel
            {
                Product = _productService.GetById(productId),
                Categories = _categoryService.GetAll()
                   };

            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Update(product);
                TempData.Add("message", "product was successfully updated");

            }

            return RedirectToAction("Update");

        }

        public ActionResult Delete (int productId)
        {

            _productService.Delete(productId);
            TempData.Add("message", "selected product was deleted!");
            return RedirectToAction("Index");
        }

        public ActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> CreateRole(CreateRoleViewModel createRoleViewModel)
        {
            if (ModelState.IsValid)
            {
                CustomIdentityRole identityRole = new CustomIdentityRole
                {
                    Name=createRoleViewModel.RoleName
                };
                IdentityResult result = await _roleManager.CreateAsync(identityRole);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Admin");
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);

                }
            }
            return View(createRoleViewModel);
        }

        public ActionResult ListAdmin()
        {

            var admins = _userManager.Users;
            return View(admins);
        }

      




    }
}
