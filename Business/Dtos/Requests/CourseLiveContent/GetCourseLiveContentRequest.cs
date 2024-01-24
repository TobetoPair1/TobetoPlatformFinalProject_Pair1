namespace Business.Dtos.Requests.CourseLiveContent;

public class GetCourseLiveContentRequest
{
	public Guid CourseId { get; set; }
	public Guid LiveContentId { get; set; }
}
