namespace Business.Dtos.Responses.Answer
{
	public class GetListAnswerResponse
	{
		public Guid Id { get; set; }
		public string QuestionDescription { get; set; }
		public string Description { get; set; }
		public string ImageUrl { get; set; }
	}
}
