using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School.Models;
using School.ViewModels;

namespace School.ViewModels
{
    public class GrShowVM:BaseVM
    {
        public List<GrVM> Grs { get; set; }
        public List<string> UniqueTime { get; set; }
    }
}
