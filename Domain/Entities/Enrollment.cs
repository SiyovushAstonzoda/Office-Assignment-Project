namespace Domain.Entities;

public class Enrollment
{
    public int Id { get; set; }
    public string? Grade { get; set; }

    //references - CourseName, StudentName
    public int CourseId { get; set; }
    public virtual Course? Course { get; set; }
    public int StudentId { get; set; }
    public virtual Student? Student { get; set; }
}
