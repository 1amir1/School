using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using School.Models;

namespace School.ViewModels
{
    public class RegModel
    {
        public List<Role> Roles { get; set; }
        public User NewUser { get; set; }
    }
}
