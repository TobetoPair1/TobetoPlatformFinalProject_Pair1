namespace Business.Dtos.Requests.InstructorSession
{
	public class DeleteInstructorSessionRequest
	{
		public Guid InstructorId { get; set; }
		public Guid SessionId { get; set; }
	}
}
