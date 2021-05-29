using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthChoice.Models;

namespace HealthChoice.Controllers
{
    public class HealthyResturentsController : Controller
    {
        List<HealthResturentsModel> siteRes = new List<HealthResturentsModel>() {
            new HealthResturentsModel{ResID= 1,ResName= "Boga Super Food", ResDescription ="BOGA is a Saudi local restaurant chain that is created and owned by Tariq Al-Hussaini.And is Offers sandwiches, salads, and fresh juices", ResLogo= "https://media-exp1.licdn.com/dms/image/C4D1BAQGllg2SUkUMGA/company-background_10000/0/1575976861836?e=2159024400&v=beta&t=ODg29H-HRO7cdmDJXe8Teg-TWGxM8d4SmUWfEbJ3FZo" },
            new HealthResturentsModel{ResID= 2,ResName="Zafran Indian Bistro", ResDescription= "Zafran Indian Bistro, the award-winning contemporary Indian restaurant. Led by a team of highly skilled and experienced chefs, Zafran focuses on North West Indian cuisine with subtle and complex flavours, yet light on the stomach.", ResLogo ="https://images.deliveryhero.io/image/talabat/restaurants/Logo_2_636493761166317762.jpg"},
            new HealthResturentsModel{ResID= 3,ResName= "leanmeal",  ResDescription ="Lean Meal Co. was the brainchild of founders Mohak Bhingarkar & Jay Krishnanunny, they both were looking for restaurants in Mumbai that would deliver fresh & healthy meals every day but there were always some problems with the existing options. Some didn't have a large menu, some said they were healthy but were very obviously not & some just gave out plain boring food that absolutely nobody wanted to eat! ", ResLogo ="https://static.wixstatic.com/media/20d7ad_a25059fa2ecb4cc08d68eed0a205427f~mv2.png/v1/fit/w_2500,h_1330,al_c/20d7ad_a25059fa2ecb4cc08d68eed0a205427f~mv2.png"}

            };
        public IActionResult Index()
        {
           
            return View(siteRes);
        }

        public ActionResult Details(int? Id)
        {
            HealthResturentsModel Res = siteRes.Find(b => b.ResID == Id);
            if (Res== null)
            {
                return RedirectToAction("index", "Errors");
            }
            else
            {
                ViewData["Res"] = Res;
                return View();
            }
           

        }


    }
}
