using Microsoft.AspNetCore.Mvc;
using System;
using Shopping.Models;
using System.Collections.Generic;

namespace Shopping.Controllers
{
    public class ProductsController : Controller
    {
        public List<ProductModel> Products = new List<ProductModel>() { 
       
      
        new ProductModel() { Id = 1, Name = "كن أنت", Price = 45.5f, Image = "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/5/5/559427.jpg?1" },
        new ProductModel() { Id = 2, Name = "أنجز أعمالك بشكل أفضل", Price = 32.0f, Image = "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/j/b/jbb282207743.jpg?1" },
        new ProductModel() { Id = 3, Name = "كتاب الجيب في الإيجابية", Price = 65.0f, Image = "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/j/b/jbb282207805.jpg?1" },
        new ProductModel() { Id = 4, Name = "الدقيقة الرابحة", Price = 23.2f, Image = "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/j/b/jbb5620na089.jpg?1" },
        new ProductModel() { Id = 5, Name = "خطوات في هدم وبناء العادات", Price = 76.2f, Image = "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/5/6/563508.jpg?1" },
        new ProductModel() { Id = 6, Name = "تركيز أفضل إنجاز أكبر", Price = 56.2f, Image = "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/j/r/jrb25520719.jpg?1" },
        new ProductModel() { Id = 7, Name = "الثقة الحقيقية", Price = 76.4f, Image = "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/j/b/jbb282206639.jpg?1" },
        new ProductModel() { Id = 8, Name = "الرقص مع الحياة", Price = 35.5f, Image = "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/j/b/jbb6030na173.jpg?1" },
        new ProductModel() { Id = 9, Name = "حينئذ والآن", Price = 34.2f, Image = "https://www.jarir.com/cdn-cgi/image/fit=contain,width=400,height=400/https://www.jarir.com/media//catalog/product/j/b/jbb282207669.jpg?1" }

    };
        public IActionResult Index(string color = "white")
        {
            ViewData["products"] = Products;
            ViewData["Color"] = color;

            return View();

        }

        public IActionResult Details(int? id=1, string color = "white")
        {

            ProductModel product = Products.Find(b => b.Id == id);

            if (product == null)
            {
                return Content("لا يوجد ");
            }
            else
            {

                ViewData["products"] = Products.Find(b => b.Id == id);
                ViewData["Color"] = color;
                return View();
            }

          

        }
    }
}