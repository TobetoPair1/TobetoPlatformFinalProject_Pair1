namespace Business.Dtos.Requests.UserCalendar
{
	public class CreateUserCalendarRequest
    {
        public Guid UserId { get; set; }
        public Guid CalenderId { get; set; }
    }
}
