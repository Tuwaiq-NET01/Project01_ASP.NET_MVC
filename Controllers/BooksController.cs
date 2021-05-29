using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project01.NET.Models;

namespace Project01.NET.Controllers
{
    public class BooksController : Controller
    {

        List<BookModel> Books = new List<BookModel>();


        public IActionResult Index()
        {
            Books.Add(new BookModel(1, "A Study in Scarlet", "Conan Doyle", "Donnue & Company", 1887, 7.49,
        "https://upload.wikimedia.org/wikipedia/commons/b/ba/ArthurConanDoyle_AStudyInScarlet.jpg"));
            Books.Add(new BookModel(2, "The Gunslinger", "Stephen King", "Plume", 1982, 14.99,
                "https://images-na.ssl-images-amazon.com/images/I/4153HF0AQAL._SY291_BO1,204,203,200_QL40_FMwebp_.jpg"));
            Books.Add(new BookModel(3, "The Hobbit", "J. R. R. Tolkien", "George Allen & Unwin", 1937, 11.79,
                "https://images-na.ssl-images-amazon.com/images/I/51uLvJlKpNL._SX321_BO1,204,203,200_.jpg"));
            Books.Add(new BookModel(4, "The Da Vinci Code", "Dan Brown", "Doubleday", 2003, 16.50,
                "https://images-na.ssl-images-amazon.com/images/I/41KuPr7kpZL._SY291_BO1,204,203,200_QL40_FMwebp_.jpg"));

            ViewData["Books"] = Books;
            return View();
        }
        public IActionResult Details(int id)
        {
            Books.Add(new BookModel(1, "A Study in Scarlet", "Conan Doyle", "Donnue & Company", 1887, 7.49,
"https://upload.wikimedia.org/wikipedia/commons/b/ba/ArthurConanDoyle_AStudyInScarlet.jpg"));
            Books.Add(new BookModel(2, "The Gunslinger", "Stephen King", "Plume", 1982, 14.99,
                "https://images-na.ssl-images-amazon.com/images/I/4153HF0AQAL._SY291_BO1,204,203,200_QL40_FMwebp_.jpg"));
            Books.Add(new BookModel(3, "The Hobbit", "J. R. R. Tolkien", "George Allen & Unwin", 1937, 11.79,
                "https://images-na.ssl-images-amazon.com/images/I/51uLvJlKpNL._SX321_BO1,204,203,200_.jpg"));
            Books.Add(new BookModel(4, "The Da Vinci Code", "Dan Brown", "Doubleday", 2003, 16.50,
                "https://images-na.ssl-images-amazon.com/images/I/41KuPr7kpZL._SY291_BO1,204,203,200_QL40_FMwebp_.jpg"));

            BookModel book = Books.Find(b => b.id == id);

            if(book == null)
            {
                return Content("The book is not available.");
            }
            else
            {
                ViewData["Book"] = book;
                return View();
            }
        }
    }
}
