namespace Business.Dtos.Responses.Homework
{
	public class UpdatedHomeworkResponse
    {
		public Guid Id { get; set; }
		public Guid CourseId { get; set; }
		public string Name { get; set; }
		public bool IsCompleted { get; set; }
		public DateTime EndOfDate { get; set; }
		public string InstructorDescription { get; set; }
		public string StudentDescription { get; set; }
	}
}
