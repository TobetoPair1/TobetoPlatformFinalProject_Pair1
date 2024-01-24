namespace Business.Dtos.Responses.Favourite;

public class DeletedFavouriteResponse
{
    public Guid Id { get; set; }
    public Guid CourseId { get; set; }
    public int Count { get; set; }
}

