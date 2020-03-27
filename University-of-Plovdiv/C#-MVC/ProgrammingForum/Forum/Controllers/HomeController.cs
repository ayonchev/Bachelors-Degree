using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Forum.Data;
using Forum.Data.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Forum.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index(string searchString)
        {
            Post[] posts = null;

            if(searchString == null)
                posts = db.Posts.ToArray();
            else
                posts = db.Posts.Where(post => post.Title.Contains(searchString)).ToArray();

            ViewBag.SearchString = searchString;

            ViewBag.Message = "All Posts";
            return View(posts);
        }

        [Authorize(Roles = "Admin, User")]
        public ActionResult GetMyPosts()
        {
            Post[] posts = null;
            var userId = User.Identity.GetUserId();

            posts = db.Posts.Where(p => p.AuthorId == userId).ToArray();

            ViewBag.Message = "My Posts";
            return View("Index", posts);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult GetUsers()
        {
            var users = db.Users
                          .Include(u => u.Comments)
                          .Include(u => u.Posts)
                          .ToArray();

            return View(users);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}