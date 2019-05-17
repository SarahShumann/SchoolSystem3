using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolSystem3.Models
{
    public class TeacherInfo
    {
        [Key]
        public int TeacherID { get; set; }
        public string OfficeLocation { get; set; }
        [Required]
        public Teacher Teacher { get; set; }
    }
}