namespace Business.Dtos.Requests.UserCourse
{
	public class CreateUserCourseRequest
	{
		public Guid UserId { get; set; }
		public Guid CourseId { get; set; }
	}
}
