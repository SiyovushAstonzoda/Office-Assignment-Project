using Domain.Entities;
namespace Domain.Dtos;

public class AddEnrollmentDto
{
    public int Id { get; set; }
    public string? Grade { get; set; }

    public int CourseId { get; set; }
    public int StudentId { get; set; }
}
