namespace Business.Dtos.Responses.Calender;

public class GetCalendarResponse
{
    public Guid Id { get; set; }
    public Guid InstructorId { get; set; }
    public Guid CourseId { get; set; }
    public bool IsCompleted { get; set; }
    public bool IsPurchased { get; set; }
    public DateTime Date { get; set; }
}
