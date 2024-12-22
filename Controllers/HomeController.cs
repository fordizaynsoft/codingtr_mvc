using codingtr.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace codingtr.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (!User.Identity!.IsAuthenticated)
            {
                return RedirectToAction("Login", "Auth");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

     
    }
}