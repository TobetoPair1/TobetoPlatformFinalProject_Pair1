namespace Business.Dtos.Requests.Application
{
	public class UpdateApplicationRequest
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string FormUrl { get; set; }
        public string State { get; set; }
    }
}
