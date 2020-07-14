using Abc.Northwind.MvcUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.Northwind.MvcUI.ViewComponents
{
    public class UserSummaryViewComponent :ViewComponent
    {
          public ViewViewComponentResult Invoke()
        {
           
            UserDetailsViewModel model = new UserDetailsViewModel
            { 
                UserName = HttpContext.User.Identity.Name
            
            };
            return View(model);
        }
    }
}
