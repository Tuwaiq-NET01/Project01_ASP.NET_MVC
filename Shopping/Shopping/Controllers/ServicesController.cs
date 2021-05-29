using Microsoft.AspNetCore.Mvc;
using Shopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Controllers
{
    public class ServicesController : Controller
    {
        private List<ServiceModel> items = new List<ServiceModel>()
            {
            new ServiceModel() { id = 1, name = "Maintenance / Parts Replacement", price = 200, image = "https://kostur.uk/wp-content/uploads/2019/12/IT-SERVICE.jpg" },
            new ServiceModel() { id = 2, name = "Software & Backup", price = 150, image = "https://crbechervaise.files.wordpress.com/2020/03/social-media-4140959_1920.jpg" },
            new ServiceModel() { id = 3, name = "Warranty Extension", price = 100, image = "https://mpng.subpng.com/20190128/cts/kisspng-computer-icons-stock-photography-royalty-free-imag-guarantee-icon-free-download-png-and-vector-5c4fddacb8cbd3.5551858415487379647569.jpg" },
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
