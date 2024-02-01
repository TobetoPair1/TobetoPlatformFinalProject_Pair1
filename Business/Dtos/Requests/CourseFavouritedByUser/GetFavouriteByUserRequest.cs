namespace Business.Dtos.Requests.CourseFavouritedByUser
{
    public class GetFavouriteByUserRequest
    {
        public Guid UserId { get; set; }
        public Guid CourseId { get; set; }
    }
}
