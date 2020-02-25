using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day26Lab18and19CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day26Lab18and19CoffeeShop.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult RegistrationForm()
        {
            return View(new RegisterUser());
        }
        public IActionResult Summary(RegisterUser user)
        {
            if (ModelState.IsValid)
            {
                return View(user);
            }
            else
            {
                return View("RegistrationForm", user);
            }
        }
        public IActionResult DisplayUserInfo(RegisterUser user)
        {
            return View(user);
        }
    }
}