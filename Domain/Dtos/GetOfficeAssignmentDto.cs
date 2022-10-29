using Domain.Entities;
namespace Domain.Dtos;

public class GetOfficeAssignmentDto
{
    public int Id { get; set; }
    public string? Location { get; set; }

    public int InstructorId { get; set; }
    public string? InstructorName { get; set; }
}
