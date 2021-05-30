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
    public class ReposController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ReposController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> Index( string url )
        {

            using (var client = new HttpClient())
            {
                var uri = new Uri(url); 
                client.DefaultRequestHeaders.Add("user-agent", "C# App"); //required
                var response = await client.GetAsync(uri);
                var res = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<Item>(res);
                ViewData["repo_info"] = data;
                return View(); 
            }
        }
    }
}
