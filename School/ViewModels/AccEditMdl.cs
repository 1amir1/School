using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School.Models;

namespace School.ViewModels
{
    public class AccEditMdl : BaseVM
    {
        public List<Role> Roles { get; set; }
        public User Usr { get; set; }
        public List<GrUser> Groups { get; set; }
    }
}
