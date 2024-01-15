namespace Business.Dtos.Requests.Favourite;

public class CreateFavouriteRequest
{
    public Guid CourseId { get; set; }
    public int Count { get; set; }
}

