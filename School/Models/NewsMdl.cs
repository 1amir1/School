using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class NewsMdl
    {
        [Key]
        public int Id { get; set; }
        public DateTime PostDT { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
