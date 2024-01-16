namespace Business.Dtos.Requests.UserLike;

public class DeleteUserLikeRequest
{
    public Guid UserId { get; set; }
    public Guid LikeId { get; set; }
}