namespace Business.Dtos.Requests.UserCalendarr
{
	public class CreateUserCalendarRequest
    {
        public Guid UserId { get; set; }
        public Guid CalenderId { get; set; }
    }
}
