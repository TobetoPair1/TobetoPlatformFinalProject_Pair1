namespace Business.Dtos.Requests.Calendar;

public class CreateCalendarRequest
{
    public Guid InstructorId { get; set; }
    public Guid CourseId { get; set; }
    public bool? IsCompleted { get; set; }
    public bool? IsPurchased { get; set; }
    public DateTime? Date {  get; set; }
}