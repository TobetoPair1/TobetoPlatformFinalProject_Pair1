namespace Business.Dtos.Responses.UserExam
{
    public class GetListUserExamResponse
    {
        public Guid UserId { get; set; }
        public Guid ExamId { get; set; }
        public string ExamTitle { get; set; }
    }
}
