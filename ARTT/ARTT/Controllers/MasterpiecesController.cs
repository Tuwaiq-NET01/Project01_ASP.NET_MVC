using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ARTT.Models;
using System.Net.Http;

using Newtonsoft.Json.Linq;


namespace ARTT.Controllers
{
    public class Masterpieces : Controller
    {
        private JObject json = JObject.Parse(HttpRequest());
        public static string HttpRequest()
        {
            using (var client = new HttpClient())
            {
                var uri = new Uri("https://api.artic.edu/api/v1/artworks?fields=id,title,artisit_display,place_of_origin,publication_history,artist_title,artist_id,category_titles,image_id&page=263");
                var response = client.GetAsync(uri);
                response.Wait();
                var result = response.Result.Content.ReadAsStringAsync();
                return result.Result;
            }
        }


        

        private List<MasterpieceModel> GenerateDatafromJson(JObject json)
        {
            List<MasterpieceModel> artworks = new List<MasterpieceModel>();
             int defaulter = 0 ; 
            foreach (var m in json["data"])
            {
                artworks.Add(new MasterpieceModel()
                {
                    id = (int) m["id"], artist_title = (string) m["artist_title"], title = (string) m["title"],
                    place_of_origin = (string) m["place_of_origin"],
                    artist_id = (int?) m["artist_id"]??defaulter, imgID = (string) m["image_id"],
                    category_titles = String.Join(",", m["category_titles"].Select(p=>p.ToString()).ToArray())
                });
            }

            return artworks; 
        }
        
        
        
        // GET
        public IActionResult Index()
        {
            ViewData["artworks"] =  GenerateDatafromJson(json);
            return View();
        }
        
        //Get 
        public IActionResult Details(int id)
        {
         
            var found =  GenerateDatafromJson(json).Find(x => x.id == id);
            if (found != null)
            {
                ViewData["found"] = found; 
                
            }
            else
            {
               return View("ErrorPage");
            }
            return View(); 
            
        }
    }
}