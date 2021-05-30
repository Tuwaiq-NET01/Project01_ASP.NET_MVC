using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TuwaiqTriviaGame.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TuwaiqTriviaGame.Controllers
{
    public class QuestionController : Controller
    {
        static List<Category> categories = new List<Category>()
        {
            new Category()
            {
                Id = 0,
            Name = "All"
            },
            new Category()
            {
                Id = 1,
            Name = ".Net"
            },
            new Category()
            {
                Id = 2,
            Name = "React"
            }

        };
        public List<Question> questions = new List<Question>
        {

            new Question
            {
                Id = 1,
                question = "تستخدم لغة الجافاسكربت في اطار عملها ",
                Answer = "React",
                Difficulty = 1,
                category = categories.Find(c => c.Id == 0),
        },
            new Question
            {
                Id = 2,
                question = "یوفر لنا ASP.NET أنواع من اطار العمل یمكن استخدامھا لبناء تطبیقات الویب من ضمنھم",
                Answer = "MVC",
                Difficulty = 1,
                category = categories.Find(c => c.Id == 0),

            }
            ,
            new Question
            {
                Id = 3,
                question = "من وظائف Model",
                Answer = "یتعامل مع قاعدة البیانات و یسھل عملیة جلبھا والتعامل معھا.",
                Difficulty = 1,
                category = categories.Find(c => c.Id == 0),

            }
            ,
            new Question
            {
                Id = 4,
                question = "من وظائف :View",
                Answer = "یتعامل مع قاعدة البیانات و یسھل عملیة جلبھا والتعامل معھا.",
                Difficulty = 1,
                category = categories.Find(c => c.Id == 0),

            }
    };
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["questions"] = questions;
            ViewData["categories"] = categories;
            return View();
        }

        public IActionResult ShowAnswer(int id)
        {
          var question =  questions.Find(q => q.Id == id);
            if (question == null) return Content("404 page not found ");
            ViewData["question"] = question;
            return View();
        }

        public IActionResult DeleteQuestion(int id)
        {
            var question =  questions.Find(q => q.Id == id);
            questions.Remove(question);
            if (question == null) return Content("404 page not found ");
            ViewData["question"] = question;
            return View();
        }
 }
}




