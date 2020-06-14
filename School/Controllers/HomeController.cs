using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using School.Models;
using School.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace School.Controllers
{
    public class HomeController : Controller
    {
        SchoolContext db;
        public HomeController(SchoolContext context)
        {
            db = context;
        }

        [HttpGet]
        [Route("")]
        [Route("/Index")]
        public IActionResult Index()
        {
            IndexVM mdl = new IndexVM();
            mdl = (IndexVM)UserToMdl(mdl);
            mdl.News = new List<NewsMdl>();
            mdl.Reviews = new List<Review>();
            mdl.Reviews = db.Reviews.Include(rv=>rv.User).OrderByDescending(rv => rv.PostDT).Take(3).ToList();
            mdl.News = db.NewsMdls.OrderByDescending(n => n.PostDT).Take(3).ToList();
            return View(mdl);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            BaseVM mdl = new BaseVM();
            mdl = UserToMdl(mdl);
            return View(mdl);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            BaseVM mdl = new BaseVM();
            mdl = UserToMdl(mdl);
            return View(mdl);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
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
