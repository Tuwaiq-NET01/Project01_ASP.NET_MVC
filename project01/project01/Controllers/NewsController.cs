using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using project01.Models;
using System.Net.Http;

namespace project01.Controllers
{
    public class NewsController : Controller
    {
        public string httpRequest()
        {
            using (var client = new HttpClient())
            {
                var uri = new Uri("https://animenewsnetwork.p.rapidapi.com/reports.xml?id=155&nskip=50&nlist=50");
                var respone = client.GetAsync(uri);
                respone.Wait();
                var result = respone.Result.Content.ReadAsStringAsync();
                return result.Result;

            }
        }
public IActionResult Index()
        {
            
            return View();
        }
    }
}
