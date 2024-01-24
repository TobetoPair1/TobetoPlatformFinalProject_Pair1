namespace Business.Dtos.Requests.CourseAsyncContent;

public class DeleteCourseAsyncContentRequest
{
	public Guid CourseId { get; set; }
	public Guid AsyncContentId { get; set; }
}

