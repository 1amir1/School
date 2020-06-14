using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using School.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace School.ViewModels
{
    public class BaseVM
    {
        public string UsrId { get; set; }
        public string UsrLogin { get; set; }
        public string FullName { get; set; }
        public string UsrRole { get; set; }
        public bool LoggedIn { get; set; }
    }
}
