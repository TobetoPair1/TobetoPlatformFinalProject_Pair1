namespace Business.Dtos.Requests.UserExam
{
    public class CreateUserExamRequest
    {
        public Guid UserId { get; set; }
        public Guid ExamId { get; set; }
    }
}
