using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;
namespace MovieApp.Controllers
{
    public class UsersController : Controller
    {
        private List<User> Users = new List<User>()
        {
            new User("abdullah", new List<MoviesRating>()
            {
                new MoviesRating(6.3f,632357),
                new MoviesRating(6.5f,503736),
                new MoviesRating(7.3f,578701),
                new MoviesRating(9.3f,399566),
                new MoviesRating(7.3f,615457)
            } ,"http://farmersca.com/wp-content/uploads/2016/07/default-profile.png" ),
            new User("Mohammed", new List<MoviesRating>()
            {
                new MoviesRating(6.3f,503736),
                new MoviesRating(8.5f,804435),
                new MoviesRating(7.2f,578701),
                new MoviesRating(8.5f,399566),
                new MoviesRating(9.1f,717192),
                new MoviesRating(7f,808023)
            }, "http://farmersca.com/wp-content/uploads/2016/07/default-profile.png")
        };
        // GET
        public IActionResult Index()
        {
            if (MoviesController.movies != null)
            {
                List<Movie> movies = MoviesController.movies;
                for (int i = 0; i < Users.Count; i++)
                {
                    var user = Users[i];
                    for (int j = 0; j < user.Ratings.Count; j++)
                    {
                        // Should Call Api To Get Movie details but for simplicity and time
                        user.Ratings[j].MovieName = movies.Find(movie => movie.id == user.Ratings[j].MovieId).title;
                        user.Ratings[j].MovieImage = movies.Find(movie => movie.id == user.Ratings[j].MovieId).poster_path;
                    }
                }
                @ViewData["Users"] = Users;
            }
            return View();

        }
    }
}