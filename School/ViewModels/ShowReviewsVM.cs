using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using School.Models;

namespace School.ViewModels
{
    public class ShowReviewsVM : BaseVM
    {
        public List<Review> Reviews { get; set; }
    }
}
