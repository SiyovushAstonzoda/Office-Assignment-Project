namespace Domain.Entities;

public class OfficeAssignment
{
    public int Id { get; set; }
    public string? Location { get; set; }

    //references - InstructorName
    public int InstructorId { get; set; }
}
