namespace Business.Dtos.Requests.CourseLikedByUser;

public class DeleteCourseLikedByUserRequest
{
    public Guid UserId { get; set; }
    public Guid CourseId { get; set; }
}