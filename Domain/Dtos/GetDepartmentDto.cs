using Domain.Entities;
namespace Domain.Dtos;

public class GetDepartmentDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Budget { get; set; }
    public TimeSpan StartDate  { get; set; }

    public int InstructorId { get; set; }
    public string? Administrator { get; set; }
    
    public virtual List<Course>? Courses { get; set; }

    public GetDepartmentDto()
    {
        StartDate = DateTime.Now.TimeOfDay;  
    }
}
