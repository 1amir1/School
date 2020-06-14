using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsrId { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public int? GrId { get; set; }
        [ForeignKey("GrId")]
        public Group UsrGr { get; set; }
        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public Role UsrRole { get; set; }

        public List<GroupTeacher> GrTeach { get; set; }
        public Review Review { get; set; }
    }
}
