namespace Domain.Dtos;

public class AddCourseAssignmentDto
{
    public int Id { get; set; }

    public int CourseId { get; set; }
    public int InstructorId { get; set; }
}
