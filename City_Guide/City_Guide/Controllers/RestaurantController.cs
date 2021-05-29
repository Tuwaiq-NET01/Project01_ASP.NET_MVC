using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using City_Guide.Models;

namespace City_Guide.Controllers
{
    public class RestaurantController : Controller
    {
        List<RestaurantModel> restaurants = new List<RestaurantModel>
            {
                new RestaurantModel {Id = 1 , name ="Sunroom Cafe & Restaurant",location="Dughaither Village (Corniche Rd.) Khobar 34611",image ="https://pbs.twimg.com/media/DdWL0TzWkAEA6Nd.jpg", phoneNumber=0138814777, description="Enjoy a new dining experience in Sunroom, where excellent hospitality is provided with tastes you'll never forget.", 
                    reviews="-The atmosphere is wonderful, lovely stuff, very good food."},
                new RestaurantModel {Id = 2 , name ="SALT Albahar",location="Al Khobar, Al Corniche (Corniche Rd.) Khobar 34411",image ="https://nicetopic.net/wp-content/uploads/2021/02/%D8%B3%D9%88%D9%84%D8%AA-%D8%A7%D9%84%D8%A8%D8%AD%D8%B1.jpg", phoneNumber=0138441232, description="Salt is the ultimate experience you want to have at the beach; with all its sand and water activities, great food and amazing vibes",
                reviews="In addition to the delicious food, you get an amazing view by the sea; the atmosphere & the whole experience are captivating! They have the yummiest burgers in town. Their beef sliders are so tender and delicious. You must try their chicken cheetos sliders. They taste so good. Yummy fries too. Overall excellent service and great view!"},
                new RestaurantModel {Id = 3 , name ="Beano Bake House",location="Prince Faisal Bin Fahd Rd. Khobar 31952",image ="https://hsaa.hsobjects.com/h/menuitems/images/001/592/426/28a56fb843f7c83874cfdacd08aef804-size900.jpeg", phoneNumber=0138988700, description="A super cute bakery providing you with cool vibes and tasty treats", 
                    reviews = "Such an adorable little bakery, the savory danish is just YUM! My favorite was the truffle with kale. Coming back again for sure!"},
                new RestaurantModel {Id = 4 , name ="Parker’s Beach House",location="Ajdan Terrace. Khobar 34414",image ="https://pbs.twimg.com/media/EoTUTHIXIAAFkIB.jpg:large", phoneNumber=920024788, description="Amazing outdoor seatings with a breathtaking view, atmosphere and food."
                ,reviews="Atmosphere is 10/10! The outside terrace is amazing, just by the water but inside seating is amazing too, with large windows allowing light in. Loved the truffle burger and fries the most"},
                new RestaurantModel {Id = 5 , name ="Al Mumtaz Restaurant",location="Rabwah District (Ibn Batota St). Khobar",image ="https://fiverr-res.cloudinary.com/images/q_auto,f_auto/gigs/126167580/original/593598cf4c5676760879e9b30427bbd12a099e6b/do-a-professional-business-logo-design.jpg", phoneNumber=0138917710, description="You cannot leave Khobar without tasting the amazingly delicious pastries from this historical establishment.", 
                    reviews="I come here everytime I visit Alkhobar and it never disappoints."},
                new RestaurantModel {Id = 6 , name ="Dopeamine",location="At Corniche park (Corniche Boulevard). Khobar 34413",image ="https://4space.ae/static/ed2479f24fbc02d9e54137116095d27f/44d11/Dopeamine%20Khobar%2002.jpg", phoneNumber=0138720877, description="Artisanal bakery & speciality coffee",
                reviews="You can feel the creativity in the menu and the quality of the food is amazing, recommended for sure!"}
            };

    public IActionResult Index()
    {
        ViewData["rests"] = restaurants;
        return View();
    }

    public IActionResult Details(int? id)
    {
        RestaurantModel rest = restaurants.Find(r => r.Id == id);
        if (rest == null)
        {
            return Content("No restaurant found");
        }
        else
        {
            ViewData["rests"] = rest;
            return View();
        }
    }
}
}

