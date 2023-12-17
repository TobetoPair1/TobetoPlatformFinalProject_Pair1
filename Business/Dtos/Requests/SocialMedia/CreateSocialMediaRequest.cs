namespace Business.Dtos.Requests.SocialMedia;

public class CreateSocialMediaRequest
{
    public Guid UserId { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
}