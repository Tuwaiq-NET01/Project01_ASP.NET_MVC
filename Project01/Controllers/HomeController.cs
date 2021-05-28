using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project01.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        string homeBar = "https://thermaltake.azureedge.net/pub/media/catalog/product/cache/e4fc6e308b66431a310dcd4dc0838059/l/2/l20m01.jpg";

        public IActionResult Index()
        {
            ViewData["homeBar"] = homeBar;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //Added

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }
    }
}
