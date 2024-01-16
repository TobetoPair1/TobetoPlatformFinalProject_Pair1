namespace Business.Dtos.Responses.Like;


public class GetListLikeResponse
{
    public Guid Id { get; set; }
    public List<GetLikeResponse> Likes { get; set; }
    
    public GetListLikeResponse(Guid id, List<GetLikeResponse> likes)
    {
        Id = id;
        Likes = likes;
    }
}

