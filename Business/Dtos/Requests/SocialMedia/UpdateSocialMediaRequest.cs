namespace Business.Dtos.Requests.SocialMedia;

public class UpdateSocialMediaRequest
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }    
}