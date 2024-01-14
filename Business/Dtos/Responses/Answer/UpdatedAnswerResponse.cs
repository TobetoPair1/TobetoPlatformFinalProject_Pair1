namespace Business.Dtos.Responses.Answer
{
	public class UpdatedAnswerResponse
	{
		public Guid Id { get; set; }
		public Guid QuestionId { get; set; }
		public string Description { get; set; }
		public string ImageUrl { get; set; }
	}
}
