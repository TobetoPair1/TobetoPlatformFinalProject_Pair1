namespace Business.Dtos.Responses.Favourite;

public class CreatedFavouritetResponse
{
	public Guid Id { get; set; }
	public Guid CourseId { get; set; }
	public int Count { get; set; }
}

