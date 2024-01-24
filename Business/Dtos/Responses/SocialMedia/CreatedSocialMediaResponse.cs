namespace Business.Dtos.Responses.SocialMedia;

public class CreatedSocialMediaResponse
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
}