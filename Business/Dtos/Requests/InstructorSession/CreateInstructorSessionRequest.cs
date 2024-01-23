namespace Business.Dtos.Requests.InstructorSession
{
	public class CreateInstructorSessionRequest
	{
        public Guid InstructorId { get; set; }
        public Guid SessionId { get; set; }
    }	
}
