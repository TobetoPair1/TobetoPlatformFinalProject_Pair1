namespace Business.Dtos.Requests.UserCalendarr
{
	public class UpdateUserCalendarRequest
	{
		public Guid UserId { get; set; }
		public Guid CalenderId { get; set; }
	}
}
