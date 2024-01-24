namespace Business.Dtos.Requests.CourseLiveContent
{
	public class UpdateCourseLiveContentRequest
    {        
        public Guid CourseId { get; set; }
        public Guid LiveContentId { get; set; }
    }
}
