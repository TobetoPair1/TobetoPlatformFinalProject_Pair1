namespace Business.Dtos.Responses.UserLike;


public class GetListUserLikeResponse
{
    public GetListUserLikeResponse(List<GetUserLikeResponse> userLikes)
    {
        UserLikes = userLikes;
    }

    public Guid UserId { get; set; }
    public Guid LikeId { get; set; }
    public List<GetUserLikeResponse> UserLikes { get; set; }
}
