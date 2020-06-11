using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Share_Free.Services;
using Sharing_Free.Domain;

namespace Share_Free.Controllers
{
    [Authorize]
    public class PostController : Controller
    {

        //[Authorize]
        //[HttpPost]
        //public IActionResult CreatePost([FromForm(Name = "title")] string title, [FromForm(Name = "description")] string description)
        //{
        //    string username = HttpContext.User.FindFirst("Username").ToString();
        //    PostService pService = new PostService();

        //    pService.CreatePost(username, title, description);

        //    return RedirectToAction("Index", "Home");
        //}

        [HttpPost]
        public IActionResult DeletePost([FromForm(Name = "postId")] int postId)
        {
            PostService pService = new PostService();


            string username = HttpContext.User.FindFirst("Username").Value.ToString();
            bool isAdmin = Convert.ToBoolean(HttpContext.User.FindFirst("IsAdmin").Value.ToString());
            List<Post> userPosts = pService.GetAllPosts();
            foreach (var post in userPosts)
            {
                if ((username == post.Username || isAdmin == true) && postId == post.Id)
                {
                    pService.DeletePost(postId);
                    break;
                }
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult ModifyPost([FromForm(Name = "postId")] int postId, [FromForm(Name = "title")] string title, [FromForm(Name = "description")] string description)
        {
            PostService pService = new PostService();

            string username = HttpContext.User.FindFirst("Username").Value.ToString();
            bool isAdmin = Convert.ToBoolean(HttpContext.User.FindFirst("IsAdmin").Value.ToString());
            List<Post> userPosts = pService.GetAllPosts();
            foreach (var post in userPosts)
            {
                if ((username == post.Username || isAdmin == true) && postId == post.Id)
                {
                    pService.ModifyPost(postId, title, description);
                    break;
                }
            }
            return RedirectToAction("Index", "Home");

        }
    }
}