using Domain.Entities;
namespace Domain.Dtos;

public class GetStudentDto
{
    public int Id { get; set; }
    public string? LastName { get; set; }
    public string? FirstMidName { get; set; }
    public TimeSpan EnrollmentDate { get; set; }

    public virtual List<Enrollment>? Enrollments { get; set; }

    public GetStudentDto()
    {
        EnrollmentDate = DateTime.Now.TimeOfDay;  
    }
}
