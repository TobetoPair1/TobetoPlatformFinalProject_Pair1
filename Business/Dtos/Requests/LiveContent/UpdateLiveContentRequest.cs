namespace Business.Dtos.Requests.LiveContent
{
	public class UpdateLiveContentRequest
    {
        public Guid Id { get; set; }
        public Guid? CategoryId { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
        public bool? IsCompleted { get; set; }
    }
}
