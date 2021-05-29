using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthChoice.Models;

namespace HealthChoice.Controllers
{
    public class GymsController : Controller
    {
        List<GymsModel> siteGyms = new List<GymsModel>() {
            new GymsModel{GymId= 1,GymNam= "Fitness Time", GymDescription ="Exercise for Health is our motto – Fitness Time strives to provide the best sports and fitness services through our growing network of facilities across the Middle East and North Africa. We believe health goals can be achieved through overall mind and body fitness.", GymLogo= "https://seeklogo.com/images/F/fitness-time-logo-19E1048F6C-seeklogo.com.png" },
            new GymsModel{GymId= 2,GymNam= "Absolutely! Gym",  GymDescription ="At ABSolutely’s all female gyms, we know that every woman is different. We recognise that there are different motivations, and importantly, different aspirations amongst women. This is why we have created easy to choose, goal defined options, for our members like Baby Momma, Blushing bride and the Wonder Years.", GymLogo ="https://www.absolutelyksa.com/images/main-logo.png"},
            new GymsModel{GymId= 3,GymNam= "Gold's Gym",  GymDescription ="Get the strength workouts, cardio equipment, group exercise classes and personal training support you need to crush your fitness goals. Are you in?", GymLogo ="https://th.bing.com/th/id/Radc1637e47b876086dde5611ddc86b41?rik=usZsypAElR%2bumQ&pid=ImgRaw"}

            };
        public IActionResult Index()
        {
          
            return View(siteGyms);
        }

        public ActionResult Details(int? Id)
        {
            GymsModel Gym = siteGyms.Find(b => b.GymId == Id);
            if (Gym == null)
            {
                return RedirectToAction("index", "Errors");
            }
            else
            {
                ViewData["Gyms"] = Gym;
                return View();
            }


        }
    }
}
