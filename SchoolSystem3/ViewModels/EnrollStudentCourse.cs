using SchoolSystem3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolSystem3.ViewModels
{
    public class EnrollStudentCourse
    {
        public ICollection<Student> Student { get; set; }
        public ICollection<Course> Course { get; set; }
        public ICollection<Enrollment> Enrollment { get; set; }

    }
}