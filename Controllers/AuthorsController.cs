using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project01.NET.Models;

namespace Project01.NET.Controllers
{
    public class AuthorsController : Controller
    {
        List<AuthorModel> Authors = new List<AuthorModel>();
        public IActionResult Index()
        {
            Authors.Add(new AuthorModel("Conan Doyle", 1859, 10));
            Authors.Add(new AuthorModel("Stephen King", 1947, 82));
            Authors.Add(new AuthorModel("J. R. R. Tolkien", 1892, 26));
            Authors.Add(new AuthorModel("Dan Brown", 1964, 8));

            ViewData["Authors"] = Authors;
            return View();
        }
    }
}
