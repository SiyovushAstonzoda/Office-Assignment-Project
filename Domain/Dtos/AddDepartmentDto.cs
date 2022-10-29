using Domain.Entities;
namespace Domain.Dtos;

public class AddDepartmentDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Budget { get; set; }
    public TimeSpan StartDate  { get; set; }

    public int InstructorId { get; set; }
    public AddDepartmentDto()
    {
        StartDate = DateTime.Now.TimeOfDay;  
    }
}
