using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School.Models;
using School.ViewModels;

namespace School.ViewModels
{
    public class ShowAccVM : BaseVM
    {
        public List<User> Users { get; set; }
    }
}
