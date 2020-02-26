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
                TempData["BagName"] = user.UserName;
                TempData["BagEmail"] = user.Email;
                TempData["BagPassword"] = user.Password;
                TempData["BagGender"] = user.Gender;
                TempData["BagPhone"] = user.PhoneNum;
                TempData["BagAge"] = user.Age;
                return View();
            }
            else
            {
                return View("RegistrationForm", user);
            }
        }
        public IActionResult DisplayUserInfo()
        {
            return View();
        }
    }
}