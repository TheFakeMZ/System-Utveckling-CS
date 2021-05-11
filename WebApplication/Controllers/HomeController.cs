using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Test()
        {
            ViewBag.Message = "test";
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "User Login page";
            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "User Sign Up";
            return View();
        }
       [HttpPost]
       [ValidateAntiForgeryToken]
        public ActionResult Register(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View();
        }   

        public ActionResult Scoreboard()
        {
            ViewBag.Message = "View the final score";
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {

            return View();
        }
    }
}
