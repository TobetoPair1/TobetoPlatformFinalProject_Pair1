namespace Business.Dtos.Requests.Answer
{
	public class CreateAnswerRequest
	{
		public Guid QuestionId { get; set; }
		public string Description { get; set; }
		public string ImageUrl { get; set; }
	}
}
