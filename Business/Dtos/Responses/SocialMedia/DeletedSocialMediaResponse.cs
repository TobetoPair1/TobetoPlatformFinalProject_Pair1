namespace Business.Dtos.Responses.SocialMedia;

public class DeletedSocialMediaResponse
{
    public Guid UserId { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
}