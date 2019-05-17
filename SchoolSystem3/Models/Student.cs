using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolSystem3.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime? EnrollmentDate { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public  ICollection<Enrollment> Enrollments { get; set; }

    }
}