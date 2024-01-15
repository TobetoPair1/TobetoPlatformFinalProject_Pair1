namespace Business.Dtos.Responses.Favourite;

public class DeletedFavouriteResponse
{
    public Guid Id { get; set; }
    public string CourseId { get; set; }
    public int Count { get; set; }
}

