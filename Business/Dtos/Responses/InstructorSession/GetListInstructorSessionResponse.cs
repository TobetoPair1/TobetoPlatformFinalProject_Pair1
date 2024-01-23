namespace Business.Dtos.Responses.InstructorSession
{
	public class GetListInstructorSessionResponse
	{
		public Guid InstructorId { get; set; }
		public Guid SessionId { get; set; }
		public string InstructorFullName { get; set; }
	}
}
