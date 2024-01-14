namespace Business.Dtos.Requests.ExamQuestion
{
	public class CreateExamQuestionRequest
	{
			public Guid ExamId { get; set; }
			public Guid QuestionId { get; set; }
	}
}
