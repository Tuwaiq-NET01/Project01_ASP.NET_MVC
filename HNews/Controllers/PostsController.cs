using System;
using System.Collections.Generic;
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

        public async Task<ActionResult> TopPosts()
        {
            var topPosts = await _postsService.GetTopPosts();
            if (topPosts == null) return Content("An error has occured");
            ViewData["TopPosts"] = topPosts;
            return View();
        }
    }
}