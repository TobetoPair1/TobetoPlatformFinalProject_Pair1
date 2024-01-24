namespace Business.Dtos.Requests.CourseLiveContent
{
	public class DeleteCourseLiveContentRequest
    {
		public Guid CourseId { get; set; }
		public Guid LiveContentId { get; set; }

	}
}
