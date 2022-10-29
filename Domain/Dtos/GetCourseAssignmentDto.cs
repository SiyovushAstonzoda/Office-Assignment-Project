using Domain.Entities;
namespace Domain.Dtos;

public class GetCourseAssignmentDto
{
    public int Id { get; set; }

    public int CourseId { get; set; }
    public string? CourseName { get; set; }
    public int InstructorId { get; set; }
    public string? InstuctorName { get; set; }
}
