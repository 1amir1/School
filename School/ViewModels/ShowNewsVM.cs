using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School.ViewModels;
using School.Models;

namespace School.ViewModels
{
    public class ShowNewsVM : BaseVM
    {
        public List<NewsMdl> NewsMdls { get; set; }
    }
}
