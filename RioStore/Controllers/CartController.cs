using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RioStore.Models;
using Newtonsoft.Json.Linq;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RioStore.Controllers
{
    public class CartController : Controller
    {
        // GET: /<controller>/
        List<Cart> CarttModels = new List<Cart>();

        public CartController()
        {
            string path = "https://fakestoreapi.com/carts";
            dynamic js = JArray.Parse(FetchAPI.httpReq(path));
            foreach (var p in js)
            {
                List<ProductsInCart> prdcts=new List<ProductsInCart>();
                foreach (var item in p.products)
                {
                    prdcts.Add(new ProductsInCart() { productId = item.productId, quantity = item.quantity });
                }
                CarttModels.Add(new Cart() { Id = p.id, UserId = p.userId, Date = p.date, Products = prdcts});
            }
        }


        // GET: /<controller>/
        public IActionResult Index()
        {// this action is eq... to https://fakestoreapi.com/products/{1}  api endpoint:

                ViewData["Carts"] = CarttModels;
                return View();
        }


        // GET: /<controller>/User/{2}
        public IActionResult User(int? id)
        {
            List<Cart> CartsByUserId = new List<Cart>();

            foreach (var cart in CarttModels)
            {
                if (cart.UserId == id)
                {
                    CartsByUserId.Add(cart);
                }
            }
            if (CartsByUserId == null)
            {
                return Content(" 404: The Cart you're looking for is not available at the moment");
            }
            else
            {
                ViewData["CartsByUserId"] = CartsByUserId;
                return View();
            }
        }


        public IActionResult CartDetails(int? id)
        {
            Cart CartById = CarttModels.Find(c => c.Id == id);
            if (CartById == null)
            {
                return Content(" 404: The Cart you're looking for is not available at the moment");
            }
            else
            {
                ViewData["CartById"] = CartById;
                return View();
            }
        }

    }
}
