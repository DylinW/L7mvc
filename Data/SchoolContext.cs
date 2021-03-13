using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

/*
tinfo200:[2021-03-02-dylinw-dykstra1] - relates the three classes contained within the models folder to one another (the information 
                                      - contained within "courses", "enrollments", and "students") 
*/
namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        //tinfo200:[2021-03-02-dylinw-dykstra1] - the actions above are overridden through the specified data tables
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}