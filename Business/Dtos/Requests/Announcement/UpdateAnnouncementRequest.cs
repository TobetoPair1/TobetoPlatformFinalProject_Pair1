namespace Business.Dtos.Requests.Announcement;

public class UpdateAnnouncementRequest
{
    public Guid Id { get; set; }
    public string Header { get; set; }
    public string Description { get; set; }
}
