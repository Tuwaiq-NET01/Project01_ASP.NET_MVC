using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RioStore.Models;
using Newtonsoft.Json.Linq;


namespace RioStore.Controllers
{
    public class UsersController : Controller
    {
        // GET: /<controller>/
        List<User> AllUsers = new List<User>();

        public UsersController()
        {
            string path = "https://fakestoreapi.com/users";
            dynamic js = JArray.Parse(FetchAPI.httpReq(path));
            foreach (var user in js)
            {
                AllUsers.Add(new User() { Id = user.id, Email = user.email, Username = user.username, Password = user.password,
                FullName= user.name.firstname + " "+ user.name.lastname, Phone=user.phone
                });
            }
        }


        // GET: /<controller>/
        public IActionResult Index()
        {// this action is eq... to https://fakestoreapi.com/products/{1}  api endpoint:

            ViewData["Users"] = AllUsers;
            return View();
        }


        public IActionResult UserDetails(int? id)
        {// this action is eq... to https://fakestoreapi.com/products/categories  api endpoint:
            User user = AllUsers.Find(u => u.Id == id); // var
            if (user == null)
            {
                return Content(" 404: The Cart you're looking for is not available at the moment");
            }
            else
            {
                ViewData["UserDetails"] = user;
                return View();
            }
        }
    }
}







    

