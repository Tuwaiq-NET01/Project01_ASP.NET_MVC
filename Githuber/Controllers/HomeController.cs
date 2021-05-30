using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Githuber.Models;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Githuber.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Index()
        {
                return View();
        }
        public async Task<IActionResult> search( string topic)
        {
            Console.WriteLine(topic);
            using (var client = new HttpClient())
            {
                var uri = new Uri($"https://api.github.com/search/repositories?q={topic}+language:csharp"); 
                client.DefaultRequestHeaders.Add("user-agent", "C# App"); //required
                var response = await client.GetAsync(uri);
                var res = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<Root>(res);
                ViewData["api_date"] = data;
                return View();
            }

        }
    }
}
