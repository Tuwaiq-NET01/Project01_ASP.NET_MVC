using FlowerShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerShop.Controllers
{
    public class HomeController : Controller
    {
        public List<ReviewModel> _Review = new List<ReviewModel>()
        {
            new ReviewModel{ UserID = 10, Username = "Rose21", Comment = "Delivered on time" },
            new ReviewModel{ UserID = 11, Username = "FlowerLover", Comment = "Very good site" },
            new ReviewModel{ UserID = 12, Username = "YasminG", Comment = "Excellent" },
            new ReviewModel{ UserID = 13, Username = "FullahS", Comment = "Good custmer service" },
            new ReviewModel{ UserID = 14, Username = "JuryH", Comment = "My product hasn't been delivered yet!" },
        };

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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
        public IActionResult CustomerReviews()
        {
            ViewData["Review"] = _Review;
            return View();
        }
    }
}
