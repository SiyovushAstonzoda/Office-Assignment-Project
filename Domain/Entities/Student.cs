namespace Domain.Entities;

public class Student
{
    public int Id { get; set; }
    public string? LastName { get; set; }
    public string? FirstMidName { get; set; }
    public TimeSpan EnrollmentDate { get; set; }

    //lists - List<Enrollment> Many to Many
    public virtual List<Enrollment>? Enrollments { get; set; }

    public Student()
    {
        EnrollmentDate = DateTime.Now.TimeOfDay;  
    }
}
