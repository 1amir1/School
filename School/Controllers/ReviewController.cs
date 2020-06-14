using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using School.Models;
using System.ComponentModel.DataAnnotations;
using School.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace School.Controllers
{
    public class ReviewController : Controller
    {
        SchoolContext db;

        public ReviewController(SchoolContext context)
        {
            db = context;
        }

        /*[Route("Reviews/Index")]
        public ActionResult Index()
        {
            List<Review> reviews = db.Reviews.ToList();
            foreach (Review rv in reviews)
            {
                db.Reviews.Remove(rv);
            }
            List<User> users = db.Users.ToList();
            foreach (User u in users)
            {
                u.Reviews = null;
                db.Users.Update(u);
            }
            db.SaveChanges();
            return RedirectToAction("ShowReviews");
        }*/

        [Route("Reviews")]
        [HttpGet]
        public ActionResult ShowReviews()
        {
            ShowReviewsVM mdl = new ShowReviewsVM();
            mdl = (ShowReviewsVM)UserToMdl(mdl);
            mdl.Reviews = new List<Review>();
            if (mdl.LoggedIn)
            {
                Review rv = db.Reviews.Include(r=>r.User).FirstOrDefault(r => r.UsrId == Convert.ToInt32(mdl.UsrId));
                if (rv != null)
                {
                    mdl.Reviews.Add(rv);                    
                }
                mdl.Reviews.AddRange(db.Reviews.Include(r => r.User).OrderByDescending(r => r.PostDT).Where(r => r.UsrId != Convert.ToInt32(mdl.UsrId)).ToList());
            }
            else
            {
                mdl.Reviews = db.Reviews.Include(r=>r.User).OrderByDescending(r => r.PostDT).ToList();
            }
            return View(mdl);
        }



        [HttpGet]
        [Authorize]
        [Route("Reviews/{Id:int}")]
        public ActionResult EditReview(int id)
        {
            ReviewVM mdl = new ReviewVM();
            mdl = (ReviewVM)UserToMdl(mdl);
            mdl.Review = db.Reviews.First(rv => rv.Id == id);
            return View(mdl);
        }

        [HttpPost]
        [Authorize]
        [Route("Reviews/{Id:int}")]
        public async Task<IActionResult> EditReview(ReviewVM mdl)
        {
            mdl.Review.PostDT = DateTime.Now;
            db.Reviews.Update(mdl.Review);
            await db.SaveChangesAsync();
            return RedirectToAction("ShowReviews");
        }


        [Route("Reviews/Add")]
        [Authorize]
        [HttpGet]
        public ActionResult AddReview()
        {
            ReviewVM mdl = new ReviewVM();
            mdl = (ReviewVM)UserToMdl(mdl);
            if (mdl.LoggedIn)
            {
                User usr = db.Users.Include(u=>u.Review).First(u => u.UsrId == Convert.ToInt32(mdl.UsrId));
                if (usr.Review != null)
                {
                    return RedirectToAction("EditReview", new { id = usr.Review.Id });
                }
            }
            return View(mdl);
        }

        [Authorize]
        [HttpPost]
        [Route("Reviews/Add")]
        public async Task<IActionResult> AddReview(ReviewVM mdl)
        {
            mdl.Review.UsrId = Convert.ToInt32(User.FindFirst(c => c.Type == "UserId").Value);
            mdl.Review.PostDT = DateTime.Now;
            db.Reviews.Add(mdl.Review);
            await db.SaveChangesAsync();
            return RedirectToAction("ShowReviews");
        }

        private BaseVM UserToMdl(BaseVM mdl)
        {
            if ((User.HasClaim(c => c.Type == "UserId")) &&
                (User.HasClaim(c => c.Type == "FullName")) &&
                (User.HasClaim(c => c.Type == ClaimsIdentity.DefaultNameClaimType)) &&
                (User.HasClaim(c => c.Type == ClaimsIdentity.DefaultRoleClaimType)))
            {
                mdl.UsrId = User.FindFirst(c => c.Type == "UserId").Value;
                mdl.UsrLogin = User.FindFirst(c => c.Type == ClaimsIdentity.DefaultNameClaimType).Value;
                mdl.FullName = User.FindFirst(c => c.Type == "FullName").Value;
                mdl.UsrRole = User.FindFirst(c => c.Type == ClaimsIdentity.DefaultRoleClaimType).Value;
                mdl.LoggedIn = true;
            }
            else
            {
                mdl.LoggedIn = false;
            }
            return mdl;
        }
    }
}