using Microsoft.AspNetCore.Mvc;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Shopping.Controllers
{
    public class ContactsController : Controller
    {
        ContactModel contact = new ContactModel();
        public IActionResult Index()
        {
            contact.NameOfStore = "Book Store ";
            contact.PhoneNumber = "011998556";
            contact.email = "book.store@hotmail.com";
            contact.Location = "AN-NAKHEEL-Riyadh";

            ViewData["contact"] = contact;
            return View();
        }
    }
}
