using GatheringCoffee.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringCoffee.Controllers
{
    public class CoffeesController : Controller
    {
        List<CoffeeModel> Coffees = new List<CoffeeModel>()
            {
                new CoffeeModel(){Id = 1 , Name = "V60" ,Description = "the V60 is one of specialty coffee’s favourite brewing methods. Within 3 minutes, you can brew an incredibly tasty coffee.", Price = 18f ,Image = "/img/V60.jpeg"},
                new CoffeeModel(){Id = 2 , Name = "Chemix" ,Description = "the Chemex will give you a remarkably clean cup of coffee", Price = 17f , Image = "/img/Chemix.jpeg"},
                new CoffeeModel(){Id = 3 , Name = "Latte" ,Description = "Amazing milky coffie where the milk is more than the coffie", Price = 15f , Image = "/img/Latte.jpeg"},
                new CoffeeModel(){Id = 4 , Name = "Espresso" ,Description = "Amazing milky coffie where the milk is more than the coffie", Price = 11f , Image = "/img/Espresso.jpeg"},
                new CoffeeModel(){Id = 5 , Name = "Cortado" ,Description = "Amazing milky coffie where the coffie is more than the milk", Price = 14f , Image = "/img/Cortado.jpeg"},

            };
        List<CoffeeModel> Coffees1 = new List<CoffeeModel>()
            {
               
                new CoffeeModel(){Id = 1 , Name = "Spanish-Latte" ,Description = "The best sweet drink available right now ", Price = 16f , Image = "/img/Spanish-Latte.jpeg"},
                new CoffeeModel(){Id = 2 , Name = "Honey-Latte" ,Description = "The 2nd best sweet drink available right now", Price = 16f , Image = "/img/Honey-Latte.jpeg"},
                new CoffeeModel(){Id = 3 , Name = "ColdPro" ,Description = "The daily favourite drink ", Price = 21f , Image = "/img/ColdPro.jpeg"},
                new CoffeeModel(){Id = 4 , Name = "Strawberry-Moheto" ,Description = "beautifully assembled summer drink where the strawberry is the main ingrediant", Price = 15f , Image = "/img/Strawberry-Moheto.jpeg"},
                new CoffeeModel(){Id = 5 , Name = "Lemon-Moheto" ,Description = "beautifully assembled summer drink where the lemon is the main ingrediant", Price = 15f , Image = "/img/Lemon-Moheto.jpeg"}


            };
        //  /Coffees/
        public IActionResult Index()
        {
            return View();
        }
        //  /Coffees/HotCaffee/
        public IActionResult HotCaffee()
        {
            ViewData["hotCoffeeModel"] = Coffees;
            return View();
        }
        //  /Coffees/ColdCaffee/
        public IActionResult ColdCaffee()
        {
            ViewData["coldCoffeeModel"] = Coffees1;
            return View();
        }
    }
}
