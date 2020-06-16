using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
//using System.Web.Http;
// using System.Web.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Share_Free.Services;
using Sharing_Free.Domain;

namespace Share_Free.Controllers
{

    [Authorize]
    [Route("[controller]")]
    public class PostController : Controller
    {

        [HttpGet("[action]")]
        public IEnumerable<Post> CreatePost()
        {
            Post createdPost = new Post();
            PostService pService = new PostService();


            List<Post> getCreatePost = pService.GetAllPosts();
            List<Post> returnPost = new List<Post>();

            for (int i = 0; i < getCreatePost.Count; i++)
            {
                var getCpost = getCreatePost[i];

                if (i > 1 && getCpost.Id > getCreatePost[i-1].Id)
                {
                    Post createdPost2 = new Post(getCpost.Id, getCpost.Username, getCpost.Title, getCpost.Description, getCpost.Date);
                    returnPost.Add(createdPost2);
                }
            }
            return returnPost;
        }

        [HttpPost("[action]")]
        public void CreatePost([FromForm(Name = "title")] string title, [FromForm(Name = "description")] string description)
        {
            string username = HttpContext.User.FindFirst("Username").ToString();
            PostService pService = new PostService();

            pService.CreatePost(username, title, description);

        }

        [HttpPost("[action]")]
        public IActionResult DeletePost([FromForm] int PostId)
        {
            PostService pService = new PostService();


            string username = HttpContext.User.FindFirst("Username").Value.ToString();
            bool isAdmin = Convert.ToBoolean(HttpContext.User.FindFirst("IsAdmin").Value.ToString());
            List<Post> userPosts = pService.GetAllPosts();
            foreach (var post in userPosts)
            {
                if ((username == post.Username || isAdmin == true) && PostId == post.Id)
                {
                    pService.DeletePost(PostId);
                    break;
                }
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost("[action]")]
        public IActionResult ModifyPost([FromForm] int modifyPostId, [FromForm] string modifyPostTitle, [FromForm] string modifyPostDescription)
        {
            PostService pService = new PostService();

            string username = HttpContext.User.FindFirst("Username").Value.ToString();
            bool isAdmin = Convert.ToBoolean(HttpContext.User.FindFirst("IsAdmin").Value.ToString());
            List<Post> userPosts = pService.GetAllPosts();
            foreach (var post in userPosts)
            {
                if ((username == post.Username || isAdmin == true) && modifyPostId == post.Id)
                {
                    pService.ModifyPost(modifyPostId, modifyPostTitle, modifyPostDescription);
                    break;
                }
            }
            return RedirectToAction("Index", "Home");

        }
    }
}