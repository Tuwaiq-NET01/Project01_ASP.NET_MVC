using GatheringCoffee.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringCoffee.Controllers
{
    public class SweetsAndFoodsController : Controller
    {
        List<SweetAndFoodModel> Sweets = new List<SweetAndFoodModel>()
            {

                new SweetAndFoodModel(){Id = 1 , Name = "Pistachio-cake" ,Description = "This is the nice Pistachio cake", Price = 28f , Image = "/img/Pistachio-cake.jpeg"},
                new SweetAndFoodModel(){Id = 2 , Name = "Brown-cake" ,Description = "This is the nice Brawn cake", Price = 23f , Image = "/img/Brown-cake.jpeg"},
                new SweetAndFoodModel(){Id = 3 , Name = "Tiramisu-Cake" ,Description = "This is the nice Tiramisu Cake", Price = 25f , Image = "/img/Tiramisu-Cake.jpg"}
            };

        List<SweetAndFoodModel> Foods = new List<SweetAndFoodModel>()
            {

                new SweetAndFoodModel(){Id = 3 , Name = "Haloumi-Sandwish" ,Description = "This is the nice Haloumi-Sandwish It consists of halloumi added to it, tomatoes, olive oil and thyme", Price = 20f , Image = "/img/Haloumi-Sandwish.jpeg"},
                new SweetAndFoodModel(){Id = 4 , Name = "Croissant" ,Description = "This is the nice Croissant It consists of nice cheese", Price = 14f , Image = "/img/Croissant.jpeg"},
                new SweetAndFoodModel(){Id = 5 , Name = "Break-Fast" ,Description = "This is the nice Croissant It consists of nice Labnah dich and Egg dich ", Price = 30f , Image = "/img/Break-Fast.jpeg"}


            };
        //  /SweetsAndFoods/
        public IActionResult Index()
        {
            return View();
        }
        //  /SweetsAndFoods/Sweet/
        public IActionResult Sweet()
        {
            ViewData["Sweets"] = Sweets;
            return View();
        }
        //  /SweetsAndFoods/Food/
        public IActionResult Food()
        {
            ViewData["Foods"] = Foods;
            return View();
        }
    }
}
