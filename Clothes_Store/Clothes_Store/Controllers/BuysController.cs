using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clothes_Store.Models;

namespace Clothes_Store.Controllers
{
    public class BuysController : Controller
    {
        public BuyModel _info = new BuyModel{};

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Bayment(string Name, string Email, int PhoneN)
        {
            _info.Name = Name;
            _info.Email = Email;
            _info.PhoneN = PhoneN;

            ViewData["Info"] = _info;
            return View();
        }


    }
}
