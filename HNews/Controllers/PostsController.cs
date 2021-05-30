using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HNews.Models;
using HNews.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HNews.Controllers
{
    public class PostsController : Controller
    {
        private readonly IPostsService _postsService;

        public PostsController(IPostsService postsService)
        {
            _postsService = postsService;
        }

        public async Task<ActionResult> Index(int id)
        {
            var post = await _postsService.GetPostById(id, true);
            if (post == null) return Content("An error has occured");
            
            ViewData["Post"] = post;
            ViewData["Comments"] = post.Comments;
            ViewData["Title"] = post.Title;
            return View();
        }

        public async Task<ActionResult> Top()
        {
            var topPosts = await _postsService.GetPosts("top");
            if (topPosts == null) return Content("An error has occured");
            ViewData["PostsList"] = topPosts;
            ViewData["Title"] = "Top posts";
            return View();
        }

        public async Task<ActionResult> New()
        {
            var newPosts = await _postsService.GetPosts("new");
            if (newPosts == null) return Content("An error has occured");
            ViewData["NewPosts"] = newPosts;
            ViewData["Title"] = "Newest posts";
            return View();
        }
    }
}