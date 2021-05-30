using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RioStore.Models;
using Newtonsoft.Json.Linq;


namespace RioStore.Controllers
{
    public class ProductsController : Controller
    {
        List<Product> productModels = new List<Product>();

        public ProductsController()
        {
            string path = "https://fakestoreapi.com/products";
            dynamic js = JArray.Parse(FetchAPI.httpReq(path));
            foreach (var p in js)
            {
                productModels.Add(new Product() { Id = p.id, Title = p.title, Price = p.price, Description=p.description, Category = p.category, Image = p.image });

            }
        }


    // GET: /<controller>/
    public IActionResult Index(int? id)
        {// this action is eq... to https://fakestoreapi.com/products/{1}  api endpoint:
            Console.WriteLine(id+" ----");
            Product Product = productModels.Find(p => p.Id == id); // var
            Console.WriteLine(Product);
            if (Product == null)
            {
                return Content(" 404: The product you're looking for is not available at the moment");
            }
            else
            {
                ViewData["Product"] = Product;
                return View();
            }
        }

        public IActionResult Categories()
        {// this action is eq... to https://fakestoreapi.com/products/categories  api endpoint:


            string path = "https://fakestoreapi.com/products/categories";
            dynamic js = JArray.Parse(FetchAPI.httpReq(path));
            Console.WriteLine(js);
            ViewData["AllCategories"] = js;
            return View();
        }


        public IActionResult Category(string category)
        {

            List<Product> QueriedProducts = new List<Product>();
            foreach (var p in productModels)
            {
                if (p.Category == category)
                {
                    QueriedProducts.Add(p);
                }

            }
            ViewData["Category"] = QueriedProducts;
            return View();
        }

    }
}
