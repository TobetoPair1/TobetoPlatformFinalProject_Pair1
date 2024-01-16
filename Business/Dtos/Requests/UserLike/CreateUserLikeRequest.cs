namespace Business.Dtos.Requests.UserLike;

public class CreateUserLikeRequest
{
    public Guid UserId { get; set; }
    public Guid LikeId { get; set; }
}