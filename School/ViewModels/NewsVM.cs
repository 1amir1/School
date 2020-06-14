using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School.Models;
using System.ComponentModel.DataAnnotations;

namespace School.ViewModels
{
    public class NewsVM:BaseVM
    {
        public NewsMdl NewsMdl { get; set; }
    }
}
