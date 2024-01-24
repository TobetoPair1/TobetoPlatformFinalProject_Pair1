namespace Business.Dtos.Requests.UserCalendarr
{
    public class DeleteUserCalendarRequest
    {
        public Guid UserId { get; set; }
        public Guid CalenderId { get; set; }
    }
}
