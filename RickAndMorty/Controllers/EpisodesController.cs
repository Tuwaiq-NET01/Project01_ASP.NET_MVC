using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using RickAndMorty.Models;
using System.Threading.Tasks;

namespace RickAndMorty.Controllers
{
    
    public class EpisodesController : Controller
    {
        List<EpisodeModel> episods = new List<EpisodeModel> { };
        public IActionResult Index()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://rickandmortyapi.com/api/");
                for(int i=1; i<=41; i++)
                {
                    //HTTP GET
                    var responseTask = client.GetAsync("episode/"+i);
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsStringAsync().Result;
                        var info = JsonConvert.DeserializeObject<Dictionary<string, object>>(readTask);
                        EpisodeModel episode = new EpisodeModel()
                        {
                            Id = i,
                            Name = (string)info.ElementAt(1).Value,
                            Episode_Code = (string)info.ElementAt(3).Value,
                            Air_date = (string)info.ElementAt(2).Value,
                            /*Characters = (string [])info.ElementAt(4).Value*/
                        };
                        episods.Add(episode);
                    }
                    else //web api sent error response 
                    {
                        //log response status here..

                        ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                    }
                }
            }
            ViewBag.Episodes = episods;
            return View();
        }
    }
}
