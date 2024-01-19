namespace Business.Dtos.Requests.Answer
{
	public class UpdateAnswerRequest
	{
		public Guid Id { get; set; }
		public string? Description { get; set; }
		public string? ImageUrl { get; set; }
	}
}
