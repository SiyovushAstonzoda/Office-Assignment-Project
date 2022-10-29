using Domain.Entities;
namespace Domain.Dtos;

public class AddStudentDto
{
    public int Id { get; set; }
    public string? LastName { get; set; }
    public string? FirstMidName { get; set; }
    public TimeSpan EnrollmentDate { get; set; }

    public AddStudentDto()
    {
        EnrollmentDate = DateTime.Now.TimeOfDay;  
    }
}
