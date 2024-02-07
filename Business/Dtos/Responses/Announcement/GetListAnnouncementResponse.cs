namespace Business.Dtos.Responses.Announcement
{
	public class GetListAnnouncementResponse
    {
        public Guid Id { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
