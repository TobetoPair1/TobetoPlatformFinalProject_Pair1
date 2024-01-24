namespace Business.Dtos.Requests.UserCalendar
{
    public class DeleteUserCalendarRequest
    {
        public Guid UserId { get; set; }
        public Guid CalenderId { get; set; }
    }
}
