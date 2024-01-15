using Entities.Concretes;
using Entities.Concretes.CrossTables;

namespace Business.Dtos.Responses.Favourite;

public class UpdatedFavouriteResponse
{
    public Guid Id { get; set; }
    public Guid CourseId { get; set; }
    public int Count { get; set; }
}

