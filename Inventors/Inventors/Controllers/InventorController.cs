using Inventors.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventors.Controllers
{
    public class InventorController : Controller
    {
        List<Inventor> InventorsList = new List<Inventor>() {
            new Inventor {Id=1, Name="Alexander Graham Bell", Nationality="United Kingdom",
                Image ="https://upload.wikimedia.org/wikipedia/commons/1/10/Alexander_Graham_Bell.jpg",
                Field = "", BirthDate = new DateTime(1847, 3, 3), DeathDate = new DateTime(1922, 8, 2)},

            new Inventor {Id=2, Name="Nikola Tesla", Nationality="Austria",
                Image ="https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/N.Tesla.JPG/800px-N.Tesla.JPG",
                Field = "", BirthDate = new DateTime(1856, 7, 10), DeathDate = new DateTime(1943, 1, 7)},

            new Inventor {Id=3, Name="Melitta Bentz", Nationality="Germany",
                Image ="https://upload.wikimedia.org/wikipedia/commons/thumb/7/76/Melitta_Bentz.jpg/800px-Melitta_Bentz.jpg",
                Field = "", BirthDate = new DateTime( 1873, 1, 31), DeathDate = new DateTime(1950, 6, 29)},

             new Inventor {Id=4, Name="Karl Benz", Nationality="Germany",
                Image ="https://upload.wikimedia.org/wikipedia/commons/thumb/5/58/Carl_Benz.png/800px-Carl_Benz.png",
                Field = "", BirthDate = new DateTime(1844, 11, 25), DeathDate = new DateTime(1929, 4, 4)} };
       


        public IActionResult Index()
        {
            ViewData["InventorsList"] = InventorsList;
            return View();
        }
    }
}
