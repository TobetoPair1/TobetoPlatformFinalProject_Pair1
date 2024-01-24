namespace Business.Dtos.Responses.Announcement
{
	public class GetAnnouncementResponse
    {
        public Guid Id { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
    }
}
