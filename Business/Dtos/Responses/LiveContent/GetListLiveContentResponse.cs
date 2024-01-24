namespace Business.Dtos.Responses.LiveContent
{
	public class GetListLiveContentResponse
    {
		public Guid Id { get; set; }
		public Guid LikeId { get; set; }
		public Guid CategoryId { get; set; }
		public string Name { get; set; }
		public string Title { get; set; }
		public bool IsCompleted { get; set; }
	}
}
