namespace Business.Dtos.Requests.UserExam
{
    public class DeleteUserExamRequest
    {
        public Guid UserId { get; set; }
        public Guid ExamId { get; set; }
    }
}
