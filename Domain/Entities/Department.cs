namespace Domain.Entities;

public class Department
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Budget { get; set; }
    public TimeSpan StartDate  { get; set; }

    //references - Administrator
    public int InstructorId { get; set; }
    //lists - List<Course>
    public virtual List<Course>? Courses { get; set; }

    public Department()
    {
        StartDate = DateTime.Now.TimeOfDay;  
    }
}
