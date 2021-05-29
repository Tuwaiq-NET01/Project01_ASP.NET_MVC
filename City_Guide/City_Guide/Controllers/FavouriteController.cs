using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using City_Guide.Models;

namespace City_Guide.Controllers
{
    public class FavouriteController : Controller
    {

        public IActionResult Index()
        {
            List<FavouriteModel> favouriteRests = new List<FavouriteModel>() {

                new FavouriteModel { Id = 1, name = "King Abdulaziz Center for World Culture (Ithra')", location = "8386 Ring Rd, Gharb Al Dhahran. Al Dhahran 34461", image = "https://www.arabnews.com/sites/default/files/styles/n_670_395/public/2020/07/18/2192281-1098022112.jpg?itok=FetoAk-H", description = "A project by Saudi Aramco serves as the advancement for the public. Saudi Aramco envisioned Ithra to be an environment for transformative experiences to unlock the power of potential through mastery in arts, science, literature, and innovation. Our facilities include Idea Lab, Library, Ithra Theater, Cinema, Ithra Museum, Children’s Museum, Energy Exhibit, The Great Hall, and the Ithra Tower; all of which are housed to provide engaging and revolutionary experiences."
                }};
                ViewData["fav"] = favouriteRests;
                return View();

            }
        }
    }

