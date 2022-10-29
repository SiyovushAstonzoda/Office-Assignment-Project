using Microsoft.EntityFrameworkCore;
using Domain.Entities;
namespace Infrastructure.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //CourseAssignment Many to Many Course/Instructor
        modelBuilder.Entity<CourseAssignment>()
        .HasOne(c => c.Course)
        .WithMany(ca => ca.CourseAssignments)
        .HasForeignKey(ci => ci.CourseId);
        
        modelBuilder.Entity<CourseAssignment>()
        .HasOne(i => i.Instructor)
        .WithMany(ca => ca.CourseAssignments)
        .HasForeignKey(ii => ii.InstructorId);

        //Enrollment Many to Many Course/Student
        modelBuilder.Entity<Enrollment>()
        .HasOne(c => c.Course)
        .WithMany(en => en.Enrollments)
        .HasForeignKey(ci => ci.CourseId);
        
        modelBuilder.Entity<Enrollment>()
        .HasOne(s => s.Student)
        .WithMany(en => en.Enrollments)
        .HasForeignKey(si => si.StudentId);
    }

    public DbSet<Course> Courses { get; set; }
    public DbSet<CourseAssignment> CourseAssignments { get; set; } //Many to Many
    public DbSet<Department> Departments { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; } //Many to Many
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
    public DbSet<Student> Students { get; set; }
}
