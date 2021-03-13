using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    /*
    tinfo200:[2021-03-02-dylinw-dykstra1] - contains all the overall information needed for a student enrollment such as the
                                          - student id, last name, first name and middle initial, and enrollment date; can
                                          - even hold a list of student enrollments
    */
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
