namespace Business.Dtos.Responses.UserCourse
{
	public class GetListUserCourseResponse
	{
		public Guid UserId { get; set; }
		public Guid CourseId { get; set; }
        public string CourseName { get; set; }
    }
}
