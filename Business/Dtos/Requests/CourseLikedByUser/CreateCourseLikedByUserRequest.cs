namespace Business.Dtos.Requests.CourseLikedByUser;

public class CreateCourseLikedByUserRequest
{
    public Guid UserId { get; set; }
    public Guid CourseId { get; set; }
}