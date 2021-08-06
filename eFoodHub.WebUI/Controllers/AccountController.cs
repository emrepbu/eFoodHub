using eFoodHub.Entities;
using eFoodHub.Services.Interfaces;
using eFoodHub.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eFoodHub.WebUI.Controllers
{
    public class AccountController : Controller
    {
        IAuthenticationServices _authServices;

        public AccountController(IAuthenticationServices authServices)
        {
            _authServices = authServices;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult SignUp(UserModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    Name = model.Name,
                    UserName = model.Email,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                };
                bool result = _authServices.CreateUser(user, model.Password);
                if (result)
                {
                    RedirectToAction("Login");
                }
            }
            return View();
        }
    }
}
