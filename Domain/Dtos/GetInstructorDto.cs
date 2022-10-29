using Domain.Entities;
namespace Domain.Dtos;

public class GetInstructorDto
{
    public int Id { get; set; }
    public string? LastName { get; set; }
    public string? FirstMidName { get; set; }
    public TimeSpan HireDate { get; set; }

    public int OfficeAssignmentId { get; set; }
    public string? OfficeAssignmentName { get; set; }

    public virtual List<CourseAssignment>? CourseAssignments { get; set; }

    public GetInstructorDto()
    {
        HireDate = DateTime.Now.TimeOfDay;  
    }
}
