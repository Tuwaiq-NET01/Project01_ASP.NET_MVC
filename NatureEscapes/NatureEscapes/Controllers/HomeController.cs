using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NatureEscapes.Models;

namespace NatureEscapes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        List<ReviewModel> reviews = new List<ReviewModel>()
        {
            new ReviewModel(){Source = "etsy", Username = "HOPE", ProductID = 6, Content = "My mom loved this soap for an assorted bundle for Mother's Day so much she made it her everyday soap!"},
            new ReviewModel(){Source = "etsy", Username = "Naomi", ProductID = 2, Content = "I bought this soap for my friend for her birthday! great soap i highly recommend it!"},
            new ReviewModel(){Source = "etsy", Username = "Brit", ProductID = 10, Content = "Highly recommend this shop one of my faves!"}
        };
        public IActionResult Index()
        {
            ViewData["reviews"] = reviews;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
