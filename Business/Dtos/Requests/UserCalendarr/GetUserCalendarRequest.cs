namespace Business.Dtos.Requests.UserCalendarr
{
    public class GetUserCalendarRequest
    {
        public Guid UserId { get; set; }
        public Guid CalenderId { get; set; }
    }
}
