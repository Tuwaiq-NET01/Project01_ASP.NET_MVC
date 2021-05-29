using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ARTT.Models;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace ARTT.Controllers
{
    public class Stories : Controller
    {
        private JObject json = JObject.Parse(HttpRequest());

        public static string HttpRequest()
        {
            using (var client = new HttpClient())
            {
                var uri = new Uri(
                    "https://api.artic.edu/api/v1/mobile-sounds?limit=30");
                var response = client.GetAsync(uri);
                response.Wait();
                var result = response.Result.Content.ReadAsStringAsync();
                return result.Result;
            }
        }


        private readonly List<StoryModel> tours = new List<StoryModel>();

        private void GenerateDatafromJson(JObject json)
        {
            int defaulter = 0;
            foreach (var m in json["data"])
            {
                tours.Add(new StoryModel()
                {
                    title = (string) m["title"], url = (string) m["web_url"],
                    transcript = (string) m["transcript"]
                });
            }
        }


        // GET
        public IActionResult Index()
        {
            GenerateDatafromJson(json);
            ViewData["tours"] = tours; 
            return View();
        }
    }
}