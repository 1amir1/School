using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace School.ViewModels
{
    public class AddGroupModel:BaseVM
    {
        public List<User> Teachers { get; set; }        
        public Group GrToAdd { get; set; }
        public List<GrUser> GrUsers { get; set; }
        public List<GrDayTime> GrTable { get; set; }
        /*public List<User> Users { get; set; }
        [BindProperty]
        public List<int> Ids { get; set; }*/
    }
}
