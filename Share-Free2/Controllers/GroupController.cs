using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Share_Free.Domain;
using Sharing_Free.Services;

namespace Share_Free.Controllers
{
    [Authorize]
    [Route("[controller]")]
    public class GroupController : Controller
    {


        // rework needed
        [HttpPost("[action]")]
        public IActionResult JoinGroup([FromForm] string groupId, [FromForm] string userId)
        {
            GroupService gService = new GroupService();
            int groupId2 = Convert.ToInt32(groupId);
            int userId2 = Convert.ToInt32(userId);
            gService.JoinGroup(userId2, groupId2);

            return View();
        }

        [HttpGet]
        public IActionResult MyGroups()
        {
            GroupService gService = new GroupService();
            List<Group> myGroups = new List<Group>();
            int userId = Convert.ToInt32(HttpContext.User.FindFirst("Id").Value);
            string username = HttpContext.User.FindFirst("Username").Value.ToString();
            myGroups = gService.UserGroups(userId, username);

            return View();
        }

        [HttpGet("[action]")] 
        public string MyUsername()
        {
            string username = HttpContext.User.FindFirst("Username").Value.ToString();
            return username;
        }



    }
}