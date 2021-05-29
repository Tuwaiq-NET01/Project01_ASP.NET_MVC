using Inventors.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventors.Controllers
{
    public class InventionController : Controller
    {
        List<Invention> InventionsList = new List<Invention>() {
        new Invention {Id=1, Name="Vehicle with gas engine operation",
                Image ="https://www.daimler.com/bilder/konzern/tradition/geschichte/anfaenge-des-automobils/benz-patent-motorwagen-w768xh384-cutout.png",
                PatentDate = new DateTime( 1886, 1, 29), PatentNumber = "37435", Description=""},
        new Invention {Id=2, Name="Electric arc lamp",
                Image ="https://upload.wikimedia.org/wikipedia/commons/thumb/9/9e/Xenon_short_arc_1.jpg/1200px-Xenon_short_arc_1.jpg",
                PatentDate = new DateTime(1886, 02, 09), PatentNumber = "335,786", Description=""},
        new Invention {Id=3, Name="Commutator for dynamo-electric machines",
                Image ="https://teslauniverse.com/sites/default/files/styles/default_extra_large_watermark/public/images/00334823-1.jpg?itok=PuAzN8Aq",
                PatentDate = new DateTime(1886, 01, 26), PatentNumber = "334,823", Description=""},
        new Invention {Id=4, Name="Alexander Graham Bell's telephone",
                Image ="https://www.mozaweb.com/mozaik3D/TCH/gyartas/bell_telefonja/960.jpg",
                PatentDate = new DateTime(1876, 03, 07), PatentNumber = "174,465", Description=""}
    };

        public IActionResult Index()
        {
            ViewData["InventionsList"] = InventionsList;
            return View();
        }

        public IActionResult Details(int? id)
        {
            ViewData["Invention"] = InventionsList.Find(b => b.Id == id);
            if (ViewData["Invention"] == null)
            {
                return Content("404");
            }
            else
            {
                return View();
            }

        }
    }
}
