namespace Business.Dtos.Responses.InstructorSession
{
	public class DeletedInstructorSessionResponse
	{
		public Guid InstructorId { get; set; }
		public Guid SessionId { get; set; }
		public string InstructorFullName { get; set; }
	}
}
