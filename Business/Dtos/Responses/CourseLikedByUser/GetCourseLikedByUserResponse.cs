namespace Business.Dtos.Responses.CourseLikedByUser
{
    public class GetCourseLikedByUserResponse
    {
        public Guid UserId { get; set; }
        public Guid ContentId { get; set; }
    }
}
