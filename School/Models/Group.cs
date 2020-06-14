using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Models
{
    public class Group
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//явное указание на автоматическую генерацию поля
        public int Id { get; set; }
        public string Table { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public string Desc { get; set; }
        public int GrTeachId { get; set; }
        [ForeignKey("GrTeachId")]
        public GroupTeacher GrTeach { get; set; }

        public List<User> Users { get; set; }

    }
}
