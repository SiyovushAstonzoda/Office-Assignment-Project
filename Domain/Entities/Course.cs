namespace Domain.Entities;

public class Course
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Credits { get; set; }
    
    //references - DepartmentName 
    public int DepartmentId { get; set; }
    public virtual Department? Department { get; set; }
    //lists - List<Enrollments> Many to Many, List<CourseAssignments> Many to Many
    public virtual List<Enrollment>? Enrollments { get; set; }
    public virtual List<CourseAssignment>? CourseAssignments { get; set; }
}
