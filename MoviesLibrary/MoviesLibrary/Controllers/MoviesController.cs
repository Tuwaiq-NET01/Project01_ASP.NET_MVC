using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc;
using MoviesLibrary.Models;
using Newtonsoft.Json.Linq;

namespace MoviesLibrary.Controllers
{
    public class MoviesController : Controller
    {
        List<MovieModel> moviesList = GetMoviesList();
        // GET
        public IActionResult Index()
        {
            ViewData["Movies"] = moviesList;
            return View();
        }
        
        public IActionResult Details(int? id)
        {
            Console.WriteLine("asd");
            MovieModel movie = moviesList.Find(m => m.Id == id);
            
            if (movie == null)
            {
                return Content("there is no Movie with that id");
            }

            ViewData["Movie"] = movie;
            return View();
        }
        
        public IActionResult Poster(int? id)
        {

            MovieModel movie = moviesList.Find(m => m.Id == id);
            
            if (movie == null)
            {
                return Content("there is no Movie with that id");
            }

            ViewData["MoviePoster"] = movie.Image;
            return View();
        }

        public static List<MovieModel> GetMoviesList()
        {
            List<MovieModel> moviesList = new List<MovieModel>();
            string html = string.Empty;
            string url = @"https://api.themoviedb.org/3/movie/popular?api_key=5b1b9f67b573e2104ae29d0da0c6104f&language=en-US&page=1";
            
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
                moviesList.Add(new MovieModel()
                {
                    Id = i + 1,
                    Name = result[i]["original_title"].ToString(),
                    Year = result[i]["release_date"].ToString(),
                    Image = "https://image.tmdb.org/t/p/w300" + result[i]["poster_path"].ToString()
                });
            }

            return moviesList;
        }
    }
}