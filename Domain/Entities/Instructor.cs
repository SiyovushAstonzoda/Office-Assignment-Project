namespace Domain.Entities;

public class Instructor
{
    public int Id { get; set; }
    public string? LastName { get; set; }
    public string? FirstMidName { get; set; }
    public TimeSpan HireDate { get; set; }

    //references - OfficeAssignmentName
    public int OfficeAssignmentId { get; set; }
    //lists - List<CourseAssignment> Many to Many
    public virtual List<CourseAssignment>? CourseAssignments { get; set; }

    public Instructor()
    {
        HireDate = DateTime.Now.TimeOfDay;  
    }
}
