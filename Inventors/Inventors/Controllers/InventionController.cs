using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventors.Controllers
{
    public class InventionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
