namespace Business.Dtos.Requests.InstructorSession
{
    public class UpdateInstructorSessionRequest
    {
        public Guid InstructorId { get; set; }
        public Guid SessionId { get; set; }
    }
}
