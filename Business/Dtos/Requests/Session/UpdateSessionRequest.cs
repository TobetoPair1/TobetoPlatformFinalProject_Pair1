namespace Business.Dtos.Requests.Session
{
	public class UpdateSessionRequest
    {
        public Guid Id { get; set; }
        public Guid? InstructorId { get; set; }
        public Guid? LiveContentId { get; set; }
        public string? RecordUrl { get; set; }
        public string? SessionLinkUrl { get; set; }
        public DateTime? StartOfTime { get; set; }
        public DateTime? EndOfTime { get; set; }
    }
}
