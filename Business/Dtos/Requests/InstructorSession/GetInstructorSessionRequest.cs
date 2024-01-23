namespace Business.Dtos.Requests.InstructorSession
{
	public class GetInstructorSessionRequest
	{
		public Guid InstructorId { get; set; }
		public Guid SessionId { get; set; }
	}	
}
