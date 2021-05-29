using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class MoviesController : Controller
    {
        public static List<Movie> movies;

        // GET
        public IActionResult Index()
        {
            using (var client = new HttpClient())
            {
                var uri = new Uri(
                    "https://api.themoviedb.org/3/movie/popular?api_key=9e058083ea188da98174ef4a8d1c2f31&language=en-US&page=1");

                var response = client.GetAsync(uri);

                response.Wait();
                var res = response.Result.Content.ReadAsStringAsync();
                movies = JsonSerializer.Deserialize<Root>(res.Result).results;
    

                @ViewData["Movies"] = movies;
                return View();
            }
        }

        public IActionResult Details(int Id)
        {
            if (movies != null)
            {
                using (var client = new HttpClient())
                {
                    var uri = new Uri(
                        $"https://api.themoviedb.org/3/movie/{Id}?api_key=9e058083ea188da98174ef4a8d1c2f31&language=en-US");

                    Movie MoiveDetails = movies.Find(movie => movie.id == Id);

                    var response = client.GetAsync(uri);

                    response.Wait();
                    var res = response.Result.Content.ReadAsStringAsync();
                    MoiveDetails = JsonSerializer.Deserialize<Movie>(res.Result);

                    @ViewData["MovieDetails"] = MoiveDetails;

                    return View();
                }
            }
            else
            {
                return View();
            }
        }
    }
}