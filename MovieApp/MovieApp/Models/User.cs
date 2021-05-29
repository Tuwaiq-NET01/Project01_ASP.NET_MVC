using System.Collections.Generic;

namespace MovieApp.Models
{
    public class User
    {
        public User(string Name , List<MoviesRating> Ratings , string ProfileImage)
        {
            this.Name = Name;
            this.Ratings = Ratings;
            this.ProfileImage = ProfileImage;
        }
        public string Name { get; set; }
        public List<MoviesRating>  Ratings { get; set; }

        public string ProfileImage { get; set; }
        
    }

    public class MoviesRating
    {
        public MoviesRating(float rating, int movieId)
        {
            this.rating = rating;
            this.MovieId = movieId;
        }
        public float rating { get; set; }
        public int MovieId { get; set; }
        
        public string MovieName { get; set; }
        public string MovieImage { get; set; }
    }
}