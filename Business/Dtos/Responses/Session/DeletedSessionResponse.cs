namespace Business.Dtos.Responses.Session
{
	public class DeletedSessionResponse
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid SessionId { get; set; }
    }
}
