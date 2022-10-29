using Domain.Entities;
namespace Domain.Dtos;

public class AddCourseDto
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Credits { get; set; }
    
    public int DepartmentId { get; set; }
}
