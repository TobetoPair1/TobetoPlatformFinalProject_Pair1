namespace Business.Dtos.Responses.Application
{
	public class CreatedApplicationResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string FormUrl { get; set; }
        public string State { get; set; }
    }
}
