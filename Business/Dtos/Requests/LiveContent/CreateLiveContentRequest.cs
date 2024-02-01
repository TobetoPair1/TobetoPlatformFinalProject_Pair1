namespace Business.Dtos.Requests.LiveContent
{
	public class CreateLiveContentRequest
    {        
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}
