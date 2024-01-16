namespace Business.Dtos.Responses.UserLike;

public class GetUserLikeResponse
{
    public Guid UserId { get; set; }
    public Guid LikeId { get; set; }
    public string UserName { get; set; }
    
}
