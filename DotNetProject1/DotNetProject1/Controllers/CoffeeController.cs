using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DotNetProject1.Models;

namespace DotNetProject1.Controllers
{
    public class CoffeeController : Controller
    {
        private Random rnd = new();
        private List<CoffeeModel> _coffeeList = new List<CoffeeModel>()
        {
            new CoffeeModel(1, "Melba Organic Specialty Ethiopia Yirgacheffe",250, 68.0, "https://cdn.qavashop.com/8448-thickbox_default/Melba-Organic-Specialty-Ethiopia-Yirgacheffe-Coffee-Beans-250g-2655.jpg"),
            new CoffeeModel(2, "AN Roastery Colombia De Lamesta Coffee Beans",1000, 132.0, "https://cdn.qavashop.com/7817-thickbox_default/AN-Roaster-El-Salvador-Oasis-Coffee-Beans-1kg-1803.jpg"),
            new CoffeeModel(3, "Melba Organic Nicaragua",250, 56.0, "https://cdn.qavashop.com/8454-thickbox_default/Melba-Organic-Specialty-Nicaragua-Whole-Coffee-Beans-250g-2659.jpg"),
            new CoffeeModel(4, "Melba Organic Santa Monica Colombia",250, 68.0, "https://cdn.qavashop.com/8447-thickbox_default/Melba-Organic-Specialty-Santa-Monica-Colombia-Whole-Coffee-Beans-250g-2661.jpg"),
            new CoffeeModel(5, "Drip on Roasted Specialty Coffee Beans - Ethiopia",250, 52.0, "https://cdn.qavashop.com/7689-thickbox_default/Drip-on-Roasted-Specialty-Coffee-Beans-Ethiopia-250g-3403.jpg"),
            new CoffeeModel(6, "Melba Roastary Colombia Huila Coffee Beans",250, 56.0, "https://cdn.qavashop.com/8452-thickbox_default/melba-roastary-colombia-huila-coffee-beans-250g.jpg"),
            new CoffeeModel(7, "Melba Roastary El Salvador Coffee Beans",250, 68.0, "https://cdn.qavashop.com/8453-thickbox_default/melba-roastary-el-salvador-coffee-beans-250g-.jpg"),
            new CoffeeModel(8, "Melba Roastary Brazil Coffee Beans",250, 68.0, "https://cdn.qavashop.com/8451-thickbox_default/melba-roastary-brazil-coffee-beans-250g.jpg")
        };
        
        // GET
        public IActionResult Index()
        {
            ViewData["CoffeeList"] = _coffeeList;

            return View();
        }

        public IActionResult Details(int id)
        {
            ViewData["Coffee"] = _coffeeList.Find(coffee => coffee.id == id);
            
            return View();
        }
    }
}