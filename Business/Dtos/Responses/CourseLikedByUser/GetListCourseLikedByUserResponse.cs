namespace Business.Dtos.Responses.CourseLikedByUser
{
    public class GetListCourseLikedByUserResponse
    {
        public Guid UserId { get; set; }
        public Guid ContentId { get; set; }
    }
}
