using SchoolSystem3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolSystem3.ViewModels
{
    public class MajorCourseModel
    {
        public IEnumerable <Major> Majors { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
        
    }
}