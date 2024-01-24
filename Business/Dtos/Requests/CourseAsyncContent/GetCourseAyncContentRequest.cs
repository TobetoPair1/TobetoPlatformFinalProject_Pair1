namespace Business.Dtos.Requests.CourseAsyncContent;

public class GetCourseAyncContentRequest
{
	public Guid CourseId { get; set; }
	public Guid AsyncContentId { get; set; }
}
