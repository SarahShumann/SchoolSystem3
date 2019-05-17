using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolSystem3.Models
{
    public class Course
    {
        
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int MajorID { get; set; }
        public virtual Major Majors { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
    }
}