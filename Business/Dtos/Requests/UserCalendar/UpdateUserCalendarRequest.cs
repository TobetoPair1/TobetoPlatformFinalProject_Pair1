namespace Business.Dtos.Requests.UserCalendar
{
	public class UpdateUserCalendarRequest
	{
		public Guid UserId { get; set; }
		public Guid CalenderId { get; set; }
	}
}
