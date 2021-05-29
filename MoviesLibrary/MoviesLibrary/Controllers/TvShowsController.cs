using System.Collections.Generic;
using System.IO;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using MoviesLibrary.Models;
using Newtonsoft.Json.Linq;

namespace MoviesLibrary.Controllers
{
    public class TvShowsController : Controller
    {
        List<TvShowModel> tvShowList = GetTvShowsList();
        
        // GET
        public IActionResult Index()
        {
            ViewData["TvShows"] = tvShowList;
            return View();
        }
        
        public IActionResult Details(int? id)
        {

            TvShowModel tvShow = tvShowList.Find(m => m.Id == id);
            
            if (tvShow == null)
            {
                return Content("there is no Produtc with that id");
            }

            ViewData["TvShow"] = tvShow;
            return View();
        }
        
        public IActionResult Poster(int? id)
        {

            TvShowModel tvShow = tvShowList.Find(m => m.Id == id);
            
            if (tvShow == null)
            {
                return Content("there is no Movie with that id");
            }

            ViewData["TvShowPoster"] = tvShow.Image;
            return View();
        }
        
        public static List<TvShowModel> GetTvShowsList()
        {
            List<TvShowModel> tvShowList = new List<TvShowModel>();
            string html = string.Empty;
            string url = @"https://api.themoviedb.org/3/tv/popular?api_key=5b1b9f67b573e2104ae29d0da0c6104f&language=en-US&page=1";
            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;
            
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
            
            var res = JObject.Parse(html);
            JArray result = JArray.Parse(res["results"].ToString());
            for (int i = 0; i < result.Count; i++)
            {
                tvShowList.Add(new TvShowModel()
                {
                    Id = i + 1,
                    Name = result[i]["name"].ToString(),
                    Year = result[i]["first_air_date"].ToString(),
                    Image = "https://image.tmdb.org/t/p/w300" + result[i]["poster_path"].ToString()
                });
            }

            return tvShowList;
        }
    }
}