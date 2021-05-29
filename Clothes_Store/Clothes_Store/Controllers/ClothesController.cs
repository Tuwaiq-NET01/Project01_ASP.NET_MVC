using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clothes_Store.Models;

namespace Clothes_Store.Controllers
{
    public class ClothesController : Controller
    {
        public List<ClotheModel> _products = new List<ClotheModel>
        {
            new ClotheModel(){Id = 1 , Name = "JW Anderson" , img = "https://cdn-images.farfetch-contents.com/15/75/25/73/15752573_30347704_1000.jpg" , Price = 73m , gender="Male"},
            new ClotheModel(){Id = 2 , Name = "Brunello Cucinelli" , img = "https://cdn-images.farfetch-contents.com/16/85/01/06/16850106_33463844_480.jpg", Price = 83m,gender="Male"}, 
            new ClotheModel(){Id = 3 , Name = "distressed straight-leg jeans" , img ="https://cdn-images.farfetch-contents.com/15/86/76/33/15867633_29264876_480.jpg" , Price = 90m, gender="Male"},
            new ClotheModel(){Id = 5 , Name = "Chloé"  , img = "https://cdn-images.farfetch-contents.com/16/84/99/60/16849960_0209cab4-b6b6-4527-9fac-454c3b30cc37_1000.jpg", Price = 100m, gender="Female"},
            new ClotheModel(){Id = 6 , Name = "market-print shirt dress"  , img = "https://cdn-images.farfetch-contents.com/16/58/22/50/16582250_33479592_480.jpg", Price = 280m, gender="Female"},
            new ClotheModel(){Id = 7 ,Name="Studio Homme jewellery-print shirt",img="https://cdn-images.farfetch-contents.com/16/00/81/69/16008169_30037205_1000.jpg",Price=150m,gender="Male"},
            new ClotheModel(){Id = 8 ,Name="graphic-print short-sleeve T-shirt",img="https://cdn-images.farfetch-contents.com/16/06/57/13/16065713_30243998_480.jpg",Price=110m,gender="Male"},
            new ClotheModel(){Id = 9 ,Name="front-fastening Tiger sweatshirt",img="https://cdn-images.farfetch-contents.com/16/83/79/82/16837982_33441103_1000.jpg",Price=100m,gender="Male"},
            new ClotheModel(){Id = 10 ,Name="Shirred Cami midi dress",img="https://cdn-images.farfetch-contents.com/16/85/11/78/16851178_33464150_480.jpg",Price=90m,gender="Female"},
            new ClotheModel(){Id = 11 ,Name="drawstring-waist cotton shorts",img="https://cdn-images.farfetch-contents.com/16/81/97/45/16819745_33438404_1000.jpg",Price=93m,gender="Male"},
            new ClotheModel(){Id = 12 ,Name="Brighton paisley print blouse",img="https://cdn-images.farfetch-contents.com/16/20/17/69/16201769_30835201_480.jpg",Price=170m,gender="Female"},
            new ClotheModel(){Id = 13 ,Name="graphic print windbreaker jacket",img="https://cdn-images.farfetch-contents.com/15/78/30/15/15783015_28929609_480.jpg",Price=300m,gender="Male"}
        };

        public IActionResult Index()
        {

            ViewData["Products"] = _products;
            return View();
        }
        
        public IActionResult Mens()
        {

            ViewData["ProductsMens"] = _products.FindAll(model => model.gender == "Male");
            return View();
        }
        public IActionResult Womens()
        {

            ViewData["ProductsWomens"] = _products.FindAll(model => model.gender == "Female");
            return View();
        }
        public IActionResult DetailsMens(int? id)
        {
            ViewData["Product"] = _products.Find(model => model.Id == id && model.gender == "Male");
            return View();
        }
        public IActionResult DetailsWomens(int? id)
        {
            ViewData["Product"] = _products.Find(model => model.Id == id && model.gender == "Female");
            return View();
        }
    }
}
