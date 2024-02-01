namespace Business.Dtos.Requests.CourseLikedByUser;

public class GetCourseLikedByUserRequest
{
    public Guid UserId { get; set; }
    public Guid CourseId { get; set; }
}