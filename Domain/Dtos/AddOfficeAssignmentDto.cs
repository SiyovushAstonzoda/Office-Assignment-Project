using Domain.Entities;
namespace Domain.Dtos;

public class AddOfficeAssignmentDto
{
    public int Id { get; set; }
    public string? Location { get; set; }

    public int InstructorId { get; set; }
}
