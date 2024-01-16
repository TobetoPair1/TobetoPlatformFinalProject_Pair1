namespace Business.Dtos.Requests.UserLike;

public class GetUserLikeRequest
{
    public Guid UserId { get; set; }
    public Guid LikeId { get; set; }
}