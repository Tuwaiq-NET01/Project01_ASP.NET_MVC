using Microsoft.AspNetCore.Mvc;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Controllers
{
    public class ProductsController : Controller
    {
        List<ProductModel> product = new List<ProductModel>() {

            new ProductModel(){ Id= 1, Name = "الحرباء الحـائرة", Price = 40.6f, Author="إريك كارل" ,Image ="https://i.pinimg.com/originals/a1/bb/91/a1bb9150bc33a0a98804ea8150a1a9f0.jpg"},
            new ProductModel(){ Id= 2, Name = "ابـق قويـاً", Price = 60.6f, Author="ديمي لوفاتو" ,Image ="https://i.pinimg.com/originals/f5/a7/50/f5a7505806c2126acd2d6a3ababd3ed5.png"},
            new ProductModel(){ Id= 3, Name = "الأسطورة", Price = 55.6f, Author="غازي القصيبي" ,Image ="https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1560137822l/27320329._SY475_.jpg"},
            new ProductModel(){ Id= 4, Name = "مُلهمــون", Price = 35.6f, Author=" صالح الخزيم" ,Image ="https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1426348211l/25141340.jpg"},
            new ProductModel(){ Id= 5, Name = "المرحلـة الملـكيـة", Price = 70.5f , Author=" د. خالد المنيف" ,Image ="https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1535560444l/36628295._SY475_.jpg"},
            new ProductModel(){ Id= 6, Name = "غــداً أجـمـل", Price = 35.6f, Author="عبدالله المغلوث" ,Image ="https://kalemat.com/public/uploads/products/prod-1300523149.jpg"},
            new ProductModel(){ Id= 7, Name = "كـبر دمـاغـك ", Price = 60.6f, Author=" د. خالد المنيف" ,Image ="https://www.nourbook.com/publice/covers_cache_webp/9/a/a/1/c5e3c0cbcbaa19881e139c37355523c6.png.webp" },
            new ProductModel(){ Id= 8, Name = "الـرقص مـع الحيَـاة", Price = 50.99f, Author="مهـدي الموسوي" ,Image ="https://www.alarabimag.com/images/thumbs/23110.jpg" },
            new ProductModel(){ Id= 9, Name = "استيقظ وعـش ", Price = 75.0f, Author="دوريثيا براند" ,Image ="https://e3raf.org/book/wp-content/uploads/sites/3/2020/01/1579351910_-%D9%88%D8%B9%D8%B4.png" }

            };

        public IActionResult Index(string color)
        {
            ViewData["color"] = color;
            ViewData["product"] = product;
            return View();
        }

        public IActionResult Details(int? id)
        {
            ProductModel pro = product.Find(b => b.Id == id);
            if (pro == null)
            {
                return Content("لايوجد كتاب ");
            }
            else
            {

                ViewData["product"] = pro;
                return View();
            }
        }

    }
}
