namespace Business.Dtos.Requests.SocialMedia;

public class UpdateSocialMediaRequest
{
    public Guid UserId { get; set; }
    public string? Name { get; set; }
    public string? Url { get; set; }
    //public User User { get; set; }
    
    
    /*
     public Guid UserId { get; set; }
       public string Name { get; set; }
       public string Url { get; set; }
       public User User { get; set; }
     */
}