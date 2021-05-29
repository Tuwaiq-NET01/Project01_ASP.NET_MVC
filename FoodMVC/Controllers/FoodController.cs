using FoodMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodMVC.Controllers
{

    public class FoodController : Controller
    {
        List<Food> foods = new List<Food>()
            {

                new Food {id =1, dishName="Zarela's Chicken Wings",  image= "https://static.wixstatic.com/media/f22774_94d182a9f1d146489ba9c660ca78be26~mv2_d_5732_3821_s_4_2.jpg/v1/fill/w_1297,h_864,al_c,q_90/f22774_94d182a9f1d146489ba9c660ca78be26~mv2_d_5732_3821_s_4_2.webp"},
                new Food {id =2, dishName=" Strawberries with lilly pillies, moscato granita and bush honey cream", image= "https://img.delicious.com.au/cXL6-CkK/w759-h506-cfill/del/2015/10/strawberries-with-lilly-pillies-moscato-granita-and-bush-honey-cream-14984-1.jpg"},
                new Food {id =3, dishName="Chocolate Cheesecake",  image="https://pbs.twimg.com/media/E2Vl6p8WYAIWs5b.jpg"},
                new Food {id =4, dishName=" Lobster Cobb Salad",  image="https://media.foodnetwork.ca/recipetracker/4622a32e-71f5-4bc5-a283-b38979c0e7ec_Mark%20McEwan's%20Lobster%20Cobb%20Salad.jpg"},
                new Food {id =5, dishName="Ciabatta and Sausage Stuffing",  image="https://www.saveur.com/app/uploads/2019/03/18/QNO6UFLWI2QL6P5SDABHWJ3HVA-2048x1536.jpg"},
                new Food {id =6, dishName="Chocolate, amaretti and fig roll with hazelnuts",  image="https://hg-images.condecdn.net/image/9p8rB9bApdK/crop/1020/f/134-1.jpg"},

            };



        public IActionResult Index()
        {
            ViewData["foods"] = foods;

            return View();
        }

       
    }
}
