using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using School.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using School.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace School.Controllers
{
    public class NewsController : Controller
    {
        private SchoolContext db;

        public NewsController(SchoolContext context)
        {
            db = context;
        }

        [Route("/News")]
        public ActionResult News()
        {

            ShowNewsVM mdl = new ShowNewsVM();
            mdl = (ShowNewsVM)UserToMdl(mdl);
            mdl.NewsMdls = new List<NewsMdl>();
            mdl.NewsMdls = db.NewsMdls.OrderByDescending(nm=>nm.PostDT).ToList();
            return View(mdl);
        }

        [Authorize(Roles = "Администратор")]
        [Route("/News/Add")]
        [HttpGet]
        public ActionResult AddNews()
        {
            NewsVM mdl = new NewsVM();
            mdl = (NewsVM)UserToMdl(mdl);
            return View(mdl);
        }

        [Authorize(Roles= "Администратор")]
        [Route("/News/Add")]
        [HttpPost]
        public async Task<IActionResult> AddNews(NewsVM mdl)
        {
            mdl.NewsMdl.PostDT = DateTime.Now;
            db.NewsMdls.Add(mdl.NewsMdl);
            await db.SaveChangesAsync();
            NewsMdl news = db.NewsMdls.First();
            return RedirectToAction("News");
        }


        [HttpGet]
        [Route("/News/{Id:int}")]
        public ActionResult EditNews(int id)
        {
            NewsVM mdl = new NewsVM();
            mdl = (NewsVM)UserToMdl(mdl);
            mdl.NewsMdl = db.NewsMdls.First(nm => nm.Id == id);
            return View(mdl);
        }

        [HttpPost]
        [Route("/News/{Id:int}")]
        [Authorize(Roles = "Администратор")]
        public async Task<IActionResult> EditNews(NewsVM mdl)
        {
            db.NewsMdls.Update(mdl.NewsMdl);
            await db.SaveChangesAsync();
            return RedirectToAction("News");
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