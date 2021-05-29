using System;
using System.Collections.Generic;
using DotNetProject1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetProject1.Controllers
{
    public class BooksController : Controller
    {
        private Random rnd = new();
        private List<BooksModel> _booksList = new List<BooksModel>()
        {
            new BooksModel(1, "Outliers","Malcolm Gladwell", 61.0, "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/4/0/400087.jpg?1"),
            new BooksModel(2, "Option B","Sheryl Sandberg", 59.0, "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/5/6/562961.jpg?1"),
            new BooksModel(3, "The Power of Now, A Guide to Spiritual Enlightenment","	Eckhart Tolle", 72.0, "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/2/1/213630.jpg?1"),
            new BooksModel(4, "7 Habits of Highly Effective People","Stephen Covey", 95.0, "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/5/4/547736.jpg?1"),
            new BooksModel(5, "Live Lagom","Anna Brones", 25.0, "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/4/9/492099.jpg?1"),
            new BooksModel(6, "Four Agreements","	Don Miguel Ruiz", 65.0, "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/1/7/174768.jpg?1"),
            new BooksModel(7, "The SecretRhonda Byrne","", 115.0, "https://www.jarir.com/cdn-cgi/image/fit=contain,width=210,height=/https://www.jarir.com/media//catalog/product/3/0/306076.jpg?1"),
            new BooksModel(8, "The Subtle Art of Not Giving a Bleep","Mark Manson", 75.0, "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/5/1/514087.jpg?1")
        };
        
        // GET
        public IActionResult Index()
        {
            ViewData["BooksList"] = _booksList;

            return View();
        }

        public IActionResult Details(int id)
        {
            ViewData["Book"] = _booksList.Find(coffee => coffee.id == id);
            
            return View();
        }
    }
}