using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Models;
using School.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace School.Controllers
{
    public class AccountController : Controller
    {
        private SchoolContext db;
        public AccountController(SchoolContext context)
        {
            db = context;
        }

        /*[Route("/Account/Index")]
        public ActionResult Index()
        {
            return Content(User.Identity.Name + " " +User.FindFirst(c=>c.Type==ClaimsIdentity.DefaultRoleClaimType).Value + " " + User.FindFirst(c => c.Type=="FullName").Value);
        }*/

        [Route("Register")]
        [HttpGet]
        public ActionResult Register()
        {
            return View();           
        }


        [Route("Register")]
        [HttpPost]
        public async Task<IActionResult> Register(User usr)
        {
            List<Role> roles = db.Roles.ToList();
            usr.RoleId = roles[1].Id;
            db.Users.Add(usr);
            await db.SaveChangesAsync();
            //return RedirectToAction("Register");
            /*User usr1 = db.Users.FirstOrDefault(c => c.Login == usr.Login && c.Pass == usr.Pass);
            return Content(usr1.Login + " " + usr1.Pass);*/
            return RedirectToAction("Index", "Home");
        }

        [Route("login")]
        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }

        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> LogIn(LoginModel mdl)
        {
            if (ModelState.IsValid)
            {
                User user = await db.Users.Include(u=>u.UsrRole).FirstOrDefaultAsync(u => u.Login == mdl.Login && u.Pass == mdl.Pass);
                int count = await db.Users.CountAsync();
                if (user != null)
                {
                    await Authenticate(user);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("Login", "Неверный логин и(или) пароль");
                }
                return View(mdl);
            }
            else
            {
                ModelState.AddModelError("Login", "Неверный логин и(или) пароль");
                return View(mdl);
            }
        }

        private async Task Authenticate(User user)
        {
            
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim("UserId",user.UsrId.ToString()),
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Login),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.UsrRole.RoleName),
                new Claim("FullName", user.FirstName + " " + user.LastName)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
            
        }


        [HttpGet]
        [Route("Accounts")]
        [Authorize(Roles = "Администратор")]
        public async Task<IActionResult> ShowAccs()
        {
            ShowAccVM mdl = new ShowAccVM();
            mdl = (ShowAccVM)UserToMdl(mdl);
            mdl.Users = new List<User>();
            mdl.Users = await db.Users
                .Include(u => u.UsrRole)
                .Include(u => u.UsrGr)
                .Include(u => u.GrTeach)
                    .ThenInclude(gr => gr.Gr).Where(u=>u.RoleId!=1).ToListAsync();
            return View("Accounts",mdl);
        }

        [HttpGet]
        [Route("Accounts/{id:int}")]
        [Authorize]
        public ActionResult EditAccount(int id)
        {
            AccEditMdl editMdl = new AccEditMdl();
            editMdl = (AccEditMdl)UserToMdl(editMdl);
            if (User.FindFirst(c => c.Type == ClaimTypes.Role).Value == "Администратор")
            {
                editMdl.Roles = db.Roles.Where(r=>r.Id!=1).ToList();
                List<Group> groups = db.Groups.Include(gr=>gr.GrTeach).ThenInclude(gt=>gt.Teacher).ToList();
                editMdl.Groups = new List<GrUser>();                
                editMdl.Usr = db.Users.
                    Include(u=>u.UsrGr).
                    Include(u=>u.GrTeach).
                        ThenInclude(gt=>gt.Gr).FirstOrDefault(u => u.UsrId == id);
                if (editMdl.Usr.RoleId == 3)
                {
                    foreach (Group gr in groups)
                    {
                        editMdl.Groups.Add(new GrUser()
                        {
                            Id = gr.Id,
                            Name = gr.Desc,
                            AddToGr = (gr.GrTeach.TeachId == editMdl.Usr.UsrId) ? true : false
                        });
                    }
                }
                else
                {
                    foreach (Group gr in groups)
                    {
                        editMdl.Groups.Add(new GrUser()
                        {
                            Id = gr.Id,
                            Name = gr.Desc,
                            AddToGr = false
                        });
                    }
                }
                return View(editMdl);
            }
            else if (User.FindFirst(c => c.Type == ClaimTypes.Role).Value == "Пользователь")
            {
                if (Convert.ToInt32(User.FindFirst(c => c.Type == "UserId").Value) == id)
                {
                    editMdl.Usr = db.Users.Include(u => u.UsrRole).
                        Include(u => u.UsrGr).FirstOrDefault(u => u.UsrId == id);
                    return View(editMdl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else if (User.FindFirst(c => c.Type == ClaimTypes.Role).Value == "Преподаватель")
            {
                if (Convert.ToInt32(User.FindFirst(c => c.Type == "UserId").Value) == id)
                {
                    List<Group> groups = db.Groups.Include(gr => gr.GrTeach).ThenInclude(gt => gt.Teacher).ToList();
                    editMdl.Groups = new List<GrUser>();
                    editMdl.Usr = db.Users.Include(u => u.UsrRole).
                        Include(u => u.GrTeach).
                            ThenInclude(gr => gr.Gr).FirstOrDefault(u => u.UsrId == id);
                    foreach (Group gr in groups)
                    {
                        if (gr.GrTeach.TeachId == id)
                        {
                            editMdl.Groups.Add(new GrUser()
                            {
                                Id = gr.Id,
                                Name = gr.Desc,
                            });
                        }                        
                    }
                    return View(editMdl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }                  
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        [Route("Accounts/{id:int}")]
        [Authorize]
        public async Task<IActionResult> EditAccount(AccEditMdl mdl)
        {
            int id = mdl.Usr.UsrId;
            db.Users.Update(mdl.Usr);
            await db.SaveChangesAsync();
            return RedirectToAction("EditAccount", mdl.Usr.UsrId);
        }

        [Authorize]
        public ActionResult LogOut()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
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