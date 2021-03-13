namespace ContosoUniversity.Models
{
    /*
    tinfo200:[2021-03-02-dylinw-dykstra1] - contains all the in-depth information needed for a student enrollment such as their
                                          - enrollment id, course id, student id, grade, and student identification
    */
    public enum Grade

    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public Student Student { get; set; }
    }
}