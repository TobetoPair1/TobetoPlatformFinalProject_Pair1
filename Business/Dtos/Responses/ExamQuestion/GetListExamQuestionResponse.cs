namespace Business.Dtos.Responses.ExamQuestion
{
	public class GetListExamQuestionResponse
	{
		public Guid ExamId { get; set; }
		public Guid QuestionId { get; set; }
        public string ExamTitle { get; set; }
        public string QuestionDescription { get; set; }
	}
}
