using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolSystem3.Models
{
    public class Major
    {
        public int MajorID { get; set; }
        public string Name { get; set; }

        [Display(Name = "Dean")]
        public int? TeacherID { get; set; }

        public Teacher Teacher { get; set; }
        public ICollection<Course> Courses { get; set; }

    }
}