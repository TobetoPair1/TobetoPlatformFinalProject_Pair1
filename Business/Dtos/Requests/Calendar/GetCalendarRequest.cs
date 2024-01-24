namespace Business.Dtos.Requests.Calendar;

public class GetCalendarRequest
{
    public Guid Id { get; set; }
    public Guid InstructorId { get; set; }
    public Guid CourseId { get; set; }
    
}