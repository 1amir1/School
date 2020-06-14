using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using School.Models;
using School.ViewModels;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace School.Controllers
{
    public class TableController : Controller
    {
        SchoolContext db;

        public TableController(SchoolContext context)
        {
            db = context;
        }

        [Route("/Groups/Index")]
        public ActionResult Index()
        {
            /*Group grr = db.Groups.First(g => g.Id == 3);
            List<User> users = db.Users.Where(u => u.GrId == 3).ToList();
            foreach (User u in users)
            {
                u.GrId = null;
            }

            db.Groups.Remove(grr);
            db.SaveChanges();
            
            List<Group> grs = db.Groups.Include(gr => gr.Users).Include(gr => gr.GrTeach).ThenInclude(gt => gt.Teacher).ToList();
            string content = "";
            foreach (Group gr in grs)
            {
                content += gr.Id.ToString() + " " + gr.Desc + " " + gr.Day + " " + gr.Time + " " + gr.GrTeach.Teacher.UsrId.ToString() + "<br>";
            }
            return Content(content);*/
            /*List<Group> grs = db.Groups.Include(gr=>gr.Users).Include(gr=>gr.GrTeach).ThenInclude(gt=>gt.Teacher).ToList();
            db.Groups.RemoveRange(grs);
            db.SaveChanges();
            return Content(db.Groups.Count().ToString());*/
            return Content("1");

        }

        [HttpGet]
        [Route("Groups")]
        public ActionResult Groups()
        {
            GrShowVM mdl = new GrShowVM();
            mdl = (GrShowVM)UserToMdl(mdl);
            mdl.Grs = new List<GrVM>();
            mdl.UniqueTime = new List<string>();
            List<Group> grs = db.Groups.ToList();
            foreach (Group gr in grs)
            {
                GrVM grVM = new GrVM();
                grVM.Desc = gr.Desc;
                grVM.Id = gr.Id;
                grVM.Table = new List<GrDayTime>();
                string[] tmpDay = gr.Day.Split(' ');
                string[] tmpTime = gr.Time.Split(' ');
                mdl.UniqueTime.AddRange(tmpTime);
                for (int i = 0; i < tmpDay.Length; i++)
                {
                    grVM.Table.Add(new GrDayTime() { Id = Convert.ToInt32(tmpDay[i]), Time = tmpTime[i] });
                }
                mdl.Grs.Add(grVM);
            }
            mdl.UniqueTime = mdl.UniqueTime.Distinct().OrderBy(dt=>dt).ToList();
            return View(mdl);
        }
        
        [HttpGet]
        [Authorize]
        [Route("Groups/{Id:int}")]
        public ActionResult EditGroup(int id)
        {
            AddGroupModel mdl = new AddGroupModel();
            mdl = (AddGroupModel)UserToMdl(mdl);
            mdl.GrToAdd = db.Groups.
                Include(gr=>gr.GrTeach).
                    ThenInclude(gt=>gt.Teacher).First(gr => gr.Id == id);
            mdl.Teachers = new List<User>();
            mdl.Teachers = db.Users.Where(u => u.RoleId == 3).ToList();
            List<User> users = new List<User>();
            users = db.Users.Where(u => u.RoleId == 2).ToList();
            mdl.GrUsers = new List<GrUser>();
            foreach (User u in users)
            {
                mdl.GrUsers.Add(
                        new GrUser()
                        {
                            Id = u.UsrId,
                            Name = u.FirstName + " " + u.LastName,
                            AddToGr = (u.GrId == id) ? true : false
                        });
            }
            mdl.GrTable = new List<GrDayTime>();
            mdl.GrTable.Add(new GrDayTime() { Id = 1, Day = "Понедельник", Time = "", Added = false });
            mdl.GrTable.Add(new GrDayTime() { Id = 2, Day = "Вторник", Time = "", Added = false });
            mdl.GrTable.Add(new GrDayTime() { Id = 3, Day = "Среда", Time = "", Added = false });
            mdl.GrTable.Add(new GrDayTime() { Id = 4, Day = "Четверг", Time = "", Added = false });
            mdl.GrTable.Add(new GrDayTime() { Id = 5, Day = "Пятница", Time = "", Added = false });
            mdl.GrTable.Add(new GrDayTime() { Id = 6, Day = "Суббота", Time = "", Added = false });
            mdl.GrTable.Add(new GrDayTime() { Id = 7, Day = "Воскресенье", Time = "", Added = false });
            string[] tmpDays = mdl.GrToAdd.Day.Split(' ');
            string[] tmpTime = mdl.GrToAdd.Time.Split(' ');
            int i = 0;
            for (int j = 0; j < mdl.GrTable.Count; j++)
            {
                if (i < tmpDays.Length)
                {
                    if (mdl.GrTable[j].Id == Convert.ToInt32(tmpDays[i]))
                    {
                        mdl.GrTable[j].Time = tmpTime[i];
                        mdl.GrTable[j].Added = true;
                        i++;
                    }
                }                
            }
            /*if (User.FindFirst(c => c.Type == ClaimsIdentity.DefaultRoleClaimType).Value == "Администратор")
            {
               /mdl.Ids = new List<int>();
                mdl.UsrRole = "Администратор";
                mdl.Teachers = db.Users.Where(u => u.RoleId == 3).ToList();
                List<User> users = db.Users.Where(u => u.RoleId == 2).ToList();
                mdl.GrUsers = new List<GrUser>();
                mdl.GrToAdd = db.Groups.
                    Include(gr => gr.Users).
                    Include(gr => gr.GrTeach).
                        ThenInclude(gt => gt.Teacher).First(gr => gr.Id == id);
                foreach (User u in users)
                {
                    mdl.GrUsers.Add(
                        new GrUser()
                        {
                            Id = u.UsrId,
                            Name = u.FirstName + " " + u.LastName,
                            AddToGr = (u.GrId == id) ? true : false
                        });
                }
            }
            else if (User.FindFirst(c => c.Type == ClaimsIdentity.DefaultRoleClaimType).Value == "Преподаватель")
            {
                mdl.UsrRole = "Преподаватель";
                mdl.GrToAdd = db.Groups.Include(gr => gr.GrTeach).First(gr => gr.Id == id);
                if (mdl.GrToAdd.GrTeach.TeachId == Convert.ToInt32(User.FindFirst(c => c.Type == "UserId").Value))
                {
                    mdl.GrToAdd = db.Groups.
                        Include(gr => gr.Users).
                        Include(gr => gr.GrTeach).
                        ThenInclude(gt => gt.Teacher).First(gr => gr.Id == id);

                }
                else
                {
                    return RedirectToAction("Groups");
                }
            }
            else if (User.FindFirst(c => c.Type == ClaimsIdentity.DefaultRoleClaimType).Value == "Пользователь")
            {
                mdl.UsrRole = "Пользователь";
                User usr = db.Users.First(u => u.UsrId == Convert.ToInt32(User.FindFirst(c => c.Type == "UserId").Value));
                if (usr.GrId == id)
                {
                    mdl.GrToAdd = db.Groups.
                        Include(gr => gr.Users).
                        Include(gr => gr.GrTeach).
                            ThenInclude(gt => gt.Teacher).First(gr => gr.Id == id);
                }
            }*/
            return View(mdl);
        }

        [Authorize(Roles = "Администратор")]
        [Route("Groups/{id:int}")]
        [HttpPost]
        public async Task<IActionResult> EditGroup(AddGroupModel mdl)
        {
            Group group = db.Groups.First(gr => gr.Id == mdl.GrToAdd.Id);
            group.Desc = mdl.GrToAdd.Desc;
            group.Table = mdl.GrToAdd.Table;
            string tmpDay = "";
            string tmpTime = "";
            foreach (GrDayTime tbl in mdl.GrTable)
            {
                if (tbl.Added)
                {
                    tmpDay += tbl.Id.ToString() + " ";
                    tmpTime += tbl.Time + " ";
                }
            }
            tmpDay = tmpDay.Trim();
            tmpTime = tmpTime.Trim();
            if (group.Day != tmpDay)
            {
                group.Day = tmpDay;
            }
            if (group.Time != tmpTime)
            {
                group.Time = tmpTime;
            }
            db.Update(group);
            foreach (GrUser gu in mdl.GrUsers)
            {
                User user = db.Users.First(u => u.UsrId == gu.Id);
                if (gu.AddToGr)
                {                    
                    user.GrId = mdl.GrToAdd.Id;
                    db.Users.Update(user);
                }
                else
                {
                    user.GrId = null;
                }
            }
            await db.SaveChangesAsync();
            return RedirectToAction("EditGroup", mdl.GrToAdd.Id);
        }

        [HttpDelete]
        [Authorize]
        //[Route("Groups/{id:int}")]
        public async Task<IActionResult> DeleteGroup(int id)
        {
            return Content(id.ToString());
        }

        [HttpGet]
        [Authorize(Roles="Администратор")]
        [Route("Groups/Add")]
        public ActionResult AddGroup()
        {
            AddGroupModel mdl = new AddGroupModel();
            mdl = (AddGroupModel)UserToMdl(mdl);
            mdl.GrUsers = new List<GrUser>();
            mdl.Teachers = new List<User>();
            mdl.GrTable = new List<GrDayTime>();
            List<User> users = db.Users.Where(u => u.RoleId == 2).ToList();
            foreach (User u in users)
            {
                mdl.GrUsers.Add(new GrUser()
                {
                    Id = u.UsrId,
                    Name = u.FirstName + " " + u.LastName,
                    AddToGr = false
                });
            }
            mdl.Teachers = db.Users.Where(u => u.RoleId == 3).ToList();
            mdl.GrTable.Add(new GrDayTime() { Id = 1, Day = "Понедельник", Time = "", Added = false });
            mdl.GrTable.Add(new GrDayTime() { Id = 2, Day = "Вторник", Time = "", Added = false });
            mdl.GrTable.Add(new GrDayTime() { Id = 3, Day = "Среда", Time = "", Added = false });
            mdl.GrTable.Add(new GrDayTime() { Id = 4, Day = "Четверг", Time = "", Added = false });
            mdl.GrTable.Add(new GrDayTime() { Id = 5, Day = "Пятница", Time = "", Added = false });
            mdl.GrTable.Add(new GrDayTime() { Id = 6, Day = "Суббота", Time = "", Added = false });
            mdl.GrTable.Add(new GrDayTime() { Id = 7, Day = "Воскресенье", Time = "", Added = false });
            return View(mdl);
        }

        [HttpPost]
        [Authorize(Roles = "Администратор")]
        [Route("Groups/Add")]
        public async Task<IActionResult> AddGroup(AddGroupModel mdl)
        {
            //return Content(mdl.Ids[0].ToString() + " " + mdl.Ids[1].ToString());
            db.Groups.Add(mdl.GrToAdd);
            if (mdl.GrUsers != null)
            {
                foreach (GrUser gu in mdl.GrUsers)
                {
                    if (gu.AddToGr)
                    {
                        User usr = await db.Users.FirstAsync(u => u.UsrId == gu.Id);
                        usr.GrId = mdl.GrToAdd.Id;
                        db.Users.Update(usr);
                    }
                }
            }
            foreach (GrDayTime dt in mdl.GrTable)
            {
                if ((dt.Added) && (String.IsNullOrEmpty(dt.Time)))
                {
                    ModelState.AddModelError("GrTable", "Время назначено не для всех выбранных дней");
                    return View(mdl);
                }
                if (dt.Added)
                {
                    mdl.GrToAdd.Day += dt.Id.ToString() + " ";
                    mdl.GrToAdd.Time += dt.Time + " ";
                }
            }
            mdl.GrToAdd.Day = mdl.GrToAdd.Day.Trim();
            mdl.GrToAdd.Time = mdl.GrToAdd.Time.Trim();
            //return Content(mdl.GrToAdd.Desc + " " + mdl.GrToAdd.Day + " " + mdl.GrToAdd.Time);
            await db.SaveChangesAsync();
            return RedirectToAction("Groups");
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