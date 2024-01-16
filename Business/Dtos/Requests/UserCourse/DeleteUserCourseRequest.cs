namespace Business.Dtos.Requests.UserCourse
{
	public class DeleteUserCourseRequest
	{
		public Guid UserId { get; set; }
		public Guid CourseId { get; set; }
	}
}
