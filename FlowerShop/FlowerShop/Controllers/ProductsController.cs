using FlowerShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerShop.Controllers
{
    public class ProductsController : Controller
    {
        public List<ProductModel> _Products = new List<ProductModel>()
        {
            new ProductModel{ ID = 1, Name = "Pink Dust", Price = 310.50m, Image = "https://floward.imgix.net/web/Files/thumPro/637447438702232017.jpg?w=500"},
            new ProductModel{ ID = 2, Name = "Breeze", Price = 322.00m, Image = "https://floward.imgix.net/web/Files/thumPro/637375823162633954.jpg?w=500"},
            new ProductModel{ ID = 3, Name = "Love Mix", Price = 360.00m, Image = "https://floward.imgix.net/web/Files/thumPro/637467433600235841.jpg?w=500"},
            new ProductModel{ ID = 4, Name = "Sleek Bouquet", Price = 200.00m, Image = "https://floward.imgix.net/web/Files/thumPro/637368837979802520.jpg?width=600"},
            new ProductModel{ ID = 5, Name = "35 Roses hand bouquet III", Price = 280.00m, Image = "https://floward.imgix.net/web/Files/thumPro/637363759603959215.jpg?width=600"},
            new ProductModel{ ID = 6, Name = "50 Roses hand bouquet II", Price = 414.00m, Image = "https://floward.imgix.net/web/Files/thumPro/637363761825283068.jpg?width=600"},
            new ProductModel{ ID = 7, Name = "White and Yellow Roses", Price = 230.50m, Image = "https://floward.imgix.net/web/Files/thumPro/637448274952847223.jpg?width=600"},
            new ProductModel{ ID = 8, Name = "Pink Roses", Price = 312.00m, Image = "https://floward.imgix.net/web/Files/thumPro/637503588358822359.jpg?width=600"},
            new ProductModel{ ID = 9, Name = "Purple Tulips", Price = 430.00m, Image = "https://floward.imgix.net/web/Files/thumPro/637502715042825399.jpg?width=600"}
        };
        public IActionResult Flowers()
        {

            ViewData["Products"] = _Products;
            return View();
        }
        public IActionResult Details(int? ID = 1)
        {
            ProductModel product = _Products.Find(b => b.ID == ID);
            if (product == null)
            {
                return Content("This product ID does not exist");
            }
            else
            {
                ViewData["Products"] = _Products.Find(b => b.ID == ID);
                return View();
            }
        }
        public IActionResult UserInfo()
        {
           return View();
        }
        public IActionResult DoneOrder()
        {
            return View();
        }
    }
}
