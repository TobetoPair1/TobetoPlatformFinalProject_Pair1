namespace Business.Dtos.Responses.Favourite;

public class GetListFavoriteResponse
{
    public Guid Id { get; set; }
    public string CourseId { get; set; }
    public string CourseName { get; set; }
    public int Count { get; set; }
}

