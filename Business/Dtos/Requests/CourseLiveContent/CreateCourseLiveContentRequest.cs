namespace Business.Dtos.Requests.CourseLiveContent
{
	public class CreateCourseLiveContentRequest
    {
        public Guid CourseId { get; set; }
        public Guid LiveContentId { get; set; }
    }
}
