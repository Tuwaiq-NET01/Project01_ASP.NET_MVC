using System;
namespace TuwaiqTriviaGame.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string question { get; set; }
        public String Answer { get; set; }
        public int Difficulty { get; set; }
        public Category category { get; set; }

    }
}
