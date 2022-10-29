using Domain.Entities;
namespace Domain.Dtos;

public class AddInstructorDto
{
    public int Id { get; set; }
    public string? LastName { get; set; }
    public string? FirstMidName { get; set; }
    public TimeSpan HireDate { get; set; }

    public int OfficeAssignmentId { get; set; }

    public AddInstructorDto()
    {
        HireDate = DateTime.Now.TimeOfDay;  
    }
}
