﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Galaxy.Controllers
{
    public class StarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
