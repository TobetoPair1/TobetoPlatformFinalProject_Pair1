namespace Business.Dtos.Responses.UserExam
{
    public class GetUserExamResponse
    {
        public Guid UserId { get; set; }
        public Guid ExamId { get; set; }
        public string ExamTitle { get; set; }
    }
}
