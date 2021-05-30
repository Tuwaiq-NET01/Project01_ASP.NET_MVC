using System.Threading.Tasks;
using HNews.Services;
using Microsoft.AspNetCore.Mvc;

namespace HNews.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }
        // GET
        // TODO: make username a required param
        public async Task<ActionResult> Index(string username)
        {
            var user = await _usersService.GetUserProfile(username);
            if (user == null) return Content("An error has occured");
            ViewData["User"] = user;
            ViewData["Title"] = user.Username;
            return View();
        }
    }
}