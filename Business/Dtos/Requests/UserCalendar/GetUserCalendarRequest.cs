namespace Business.Dtos.Requests.UserCalendar
{
    public class GetUserCalendarRequest
    {
        public Guid UserId { get; set; }
        public Guid CalenderId { get; set; }
    }
}
