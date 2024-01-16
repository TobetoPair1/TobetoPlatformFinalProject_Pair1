namespace Business.Dtos.Requests.UserExam
{
    public class GetUserExamRequest
    {
        public Guid UserId { get; set; }
        public Guid ExamId { get; set; }
    }
}
