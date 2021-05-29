using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shopping.Models;

namespace Shopping.Controllers
{
    public class ProductsController : Controller
    {
        private List<ProductModel> items = new List<ProductModel>()
            {
            new ProductModel() { id = 1, name = "iPhone 12 Pro", brand = "Apple", price = 1099, image = "https://specials-images.forbesimg.com/imageserve/60a91f9a5f6002a4c8174108/960x0.jpg?cropX1=148&cropX2=1225&cropY1=0&cropY2=1038" },
            new ProductModel() { id = 2, name = "iPad Pro", brand = "Apple", price = 1599, image = "https://images-na.ssl-images-amazon.com/images/I/7118Z2RPOdL._AC_SX679_.jpg" },
            new ProductModel() { id = 3, name = "Mac Book Air", brand = "Apple", price = 2599, image = "https://www.techrepublic.com/a/hub/i/r/2020/11/11/2c2953e9-ac41-4841-804d-04cbc50e0c6f/resize/1200x900/7c2f0f4124e04016bb9fa17c8c3f1837/screen-shot-2020-11-11-at-10-13-07-am.jpg" },
            new ProductModel() { id = 4, name = "Beats solo3 Wireless Headphones", brand = "Apple", price = 300, image = "https://static.bhphoto.com/images/multiple_images/images500x500/1474305464_IMG_687773.jpg" },
            new ProductModel() { id = 5, name = "Apple Watch", brand = "Apple", price = 499, image = "https://cdn.shoplightspeed.com/shops/611777/files/17704548/1500x4000x3/apple-apple-watch-series-5-gps-44mm-gold-aluminum.jpg" },
            new ProductModel() { id = 6, name = "Apple TV", brand = "Apple", price = 199, image = "https://images-na.ssl-images-amazon.com/images/I/51Y-Dulc3bL._AC_SX569_.jpg" }
            };
        public IActionResult Index()
        {
            
            
            ViewData["Items"] = items;
            return View(items);
                        
        }
        public IActionResult Details(int? id)
        {
            ViewData["Items"] = items.Find(model => model.id == id);
            if (id == null)
            {
                return Content("لا يوجد منتج بهذا الرقم");
            }
            else
            {

            }
            
            return View();
        }
    }
}
