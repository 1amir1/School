using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School.Models;

namespace School.ViewModels
{
    public class IndexVM : BaseVM
    {
        public List<NewsMdl> News { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
