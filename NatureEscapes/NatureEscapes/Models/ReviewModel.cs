using System;
namespace NatureEscapes.Models
{
    public class ReviewModel
    { 
        public string Source { get; set; }
        public string Username { get; set; }
        public int ProductID { get; set; }
        public string Content { get; set; }

        public ReviewModel()
        {

        }
    }
}
