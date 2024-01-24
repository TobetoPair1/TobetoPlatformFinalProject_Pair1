namespace Business.Dtos.Requests.Homework
{
	public class UpdateHomeworkRequest
    {
        public Guid Id { get; set; }
        public Guid? CourseId { get; set; }
        public DateTime? EndOfDate { get; set; }
        public string? InstructorDescription { get; set; }
        public string? StudentDescription { get; set; }
    }
}
