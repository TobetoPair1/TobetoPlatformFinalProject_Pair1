namespace Business.Dtos.Responses.Favourite;

public class GetFavouriteResponse
{
    public Guid Id { get; set; }
    public string CourseId { get; set; }
    public string CourseName { get; set; }
    public int Count { get; set; }
}

