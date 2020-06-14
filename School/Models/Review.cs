using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Models
{
    public class Review
    { 
        [Key]
        public int Id { get; set; }
        public DateTime PostDT { get; set; }
        public int UsrId { get; set; }
        [ForeignKey("UsrId")]
        public User User { get; set; }
        public int Rate { get; set; }
        public string Text { get; set; }

    }
}
