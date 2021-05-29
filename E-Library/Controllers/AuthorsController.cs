using E_Library.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Library.Controllers
{
    public class AuthorsController : Controller
    {
        List<Author> authors = new List<Author>()
        {
            new Author(){ Id= 1, Name= "Abdulmajeed Almaymuni", BooksWritten = 2, About= "A Software engineer who is very interested in software testing"},
            new Author(){ Id=2, Name="Saeed Alqarni", BooksWritten = 1, About= "A Software engineer who is interested in web development"}
        };
        public IActionResult Index()
        {
            ViewData["Authors"] = authors;
            return View();
        }

        public IActionResult Details(int? id)
        {
            ViewBag.author = authors.Find(a => a.Id == id);
            return View();
        }
    }
}
