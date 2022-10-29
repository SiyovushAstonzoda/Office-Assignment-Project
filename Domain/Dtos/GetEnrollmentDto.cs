using Domain.Entities;
namespace Domain.Dtos;

public class GetEnrollmentDto
{
    public int Id { get; set; }
    public string? Grade { get; set; }

    public int CourseId { get; set; }
    public string? CourseName { get; set; }
    public int StudentId { get; set; }
    public string? StudentName { get; set; }
}
