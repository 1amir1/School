using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class GalleryImage
    {
        [Key]
        public int Id { get; set; }
        public string Caption { get; set; }
        public string ImageUrl { get; set; }
    }
}
