using Forum.Data;
using Forum.Data.Models;
using Forum.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Forum.Controllers
{
    [Authorize(Roles = "User, Admin")]
    public class PostsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [AllowAnonymous]
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous]
        public ActionResult Details(int id)
        {
            Post post = db.Posts
                          .Include(p => p.Author)
                          .Include("Comments.Author")
                .SingleOrDefault(p => p.Id == id);

            if (post == null)
                return HttpNotFound();

            return View(post);
        }

        // GET: Posts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Posts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create(PostViewModel postData)
        {
            string fileName = null;
            string path = null;

            if (postData.ProblemImage != null)
            {
                fileName = Path.GetFileName(postData.ProblemImage.FileName);
                path = Path.Combine(Server.MapPath("~/Images"), fileName);
                postData.ProblemImage.SaveAs(path);
            }

            if (ModelState.IsValid)
            {
                var post = new Post
                {
                    Title = postData.Title,
                    Content = postData.Content,
                    ImagePath = fileName,
                    DateCreated = DateTime.Now,
                    AuthorId = User.Identity.GetUserId()
                };

                db.Posts.Add(post);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(postData);
        }

        // GET: Posts/Edit/5
        public ActionResult Edit(int id)
        {
            Post post = db.Posts.Find(id);

            if (post == null)
                return HttpNotFound();

            if (post.AuthorId != User.Identity.GetUserId())
            {
                ViewBag.Message = "You are not allowed to edit other users' posts!";
                return View("Error");
            }

            return View(post);
        }

        [HttpPost]
        public ActionResult Edit(Post post)
        {
            if (ModelState.IsValid)
            {
                db.Entry(post).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(post);
        }


        // POST: Posts/Delete/5
        public ActionResult Delete(int id)
        {
            Post post = db.Posts.Find(id);

            if (post.AuthorId != User.Identity.GetUserId() && !User.IsInRole("Admin"))
            {
                ViewBag.Message = "You are not allowed to delete other users' posts!";
                return View("Error");
            }

            db.Posts.Remove(post);
            db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        public ActionResult AddComment(CommentViewModel commentData)
        {
            var comment = new Comment
            {
                Content = commentData.Content,
                PostId = commentData.PostId,
                DateCreated = DateTime.Now,
                AuthorId = User.Identity.GetUserId()
            };

            db.Posts.Find(comment.PostId).Comments.Add(comment);
            db.SaveChanges();

            return RedirectToAction("Details", "Posts", new { id = commentData.PostId });
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
