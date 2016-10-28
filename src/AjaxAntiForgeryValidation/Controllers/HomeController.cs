using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AjaxAntiForgeryValidation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        [ValidateAntiForgeryToken(Order = 27)]
        public IActionResult Antiforgery()
        {
            return Content("Doesn't matter");
        }

        public IActionResult Login()
        {
            return Content("Login!");
        }

        public IActionResult Logout()
        {
            return Content("Logout!");
        }
    }
}
