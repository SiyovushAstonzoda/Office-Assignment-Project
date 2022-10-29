using Domain.Entities;
namespace Domain.Dtos;

public class GetCourseDto
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Credits { get; set; }
    
    public int DepartmentId { get; set; }
    public string? DepartmentName { get; set; }
    
    public virtual List<Enrollment>? Enrollments { get; set; }
    public virtual List<CourseAssignment>? CourseAssignments { get; set; }
}
