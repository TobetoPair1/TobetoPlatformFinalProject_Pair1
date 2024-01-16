namespace Business.Dtos.Requests.UserCourse
{
	public class GetUserCourseRequest
	{
		public Guid? UserId { get; set; }
		public Guid? CourseId { get; set; }
	}
}
