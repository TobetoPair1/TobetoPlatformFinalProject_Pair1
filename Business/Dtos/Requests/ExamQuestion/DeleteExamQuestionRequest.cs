namespace Business.Dtos.Requests.ExamQuestion
{
	public class DeleteExamQuestionRequest
	{
		public Guid ExamId { get; set; }
		public Guid QuestionId { get; set; }
	}
}
