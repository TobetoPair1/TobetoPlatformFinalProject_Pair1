namespace Business.Dtos.Requests.Favourite;

public class UpdateFavouriteRequest
{
    public Guid CourseId { get; set; }
    public int Count { get; set; }
}

