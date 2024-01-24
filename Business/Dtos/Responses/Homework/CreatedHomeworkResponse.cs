namespace Business.Dtos.Responses.Homework
{
	public class CreatedHomeworkResponse
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public DateTime EndOfDate { get; set; }
        public string InstructorDescription { get; set; }
        public string StudentDescription { get; set; }
    }
}
