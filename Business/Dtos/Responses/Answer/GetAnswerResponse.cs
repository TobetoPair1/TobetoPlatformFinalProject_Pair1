namespace Business.Dtos.Responses.Answer
{
	public class GetAnswerResponse
	{
		public Guid Id { get; set; }
		public string QuestionDescription { get; set; }
		public string Description { get; set; }
		public string ImageUrl { get; set; }
	}
}
