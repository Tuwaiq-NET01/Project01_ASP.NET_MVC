using Microsoft.AspNetCore.Mvc;
using Shopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Controllers
{
    public class AuthorsController : Controller
    {

        public List<AuthorModel> Authors = new List<AuthorModel>() {


        new AuthorModel() { Id = 1, Name = "إيهاب حمارنة", Email = "iehab@outlook.com", AuthorBookName = "كن أنت", AuthorBookImage = "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/5/5/559427.jpg?1" },
        new AuthorModel() { Id = 2,Name = "داميان ماسون", Email = "daimean@outlook.com", AuthorBookName = "أنجز أعمالك بشكل أفضل", AuthorBookImage = "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/j/b/jbb282207743.jpg?1" } };
       
        public IActionResult Index()
        {
            ViewData["Authors"] = Authors;
            return View();
        }
    }
}
