namespace Business.Dtos.Responses.Favourite;

public class GetListFavouriteResponse
{
    public Guid Id { get; set; }
    public Guid CourseId { get; set; }
    public string CourseName { get; set; }
    public int Count { get; set; }
}

