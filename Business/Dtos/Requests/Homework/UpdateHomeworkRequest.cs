namespace Business.Dtos.Requests.Homework
{
	public class UpdateHomeworkRequest
    {
        public Guid Id { get; set; }
        public Guid? CourseId { get; set; }
		public Guid? LikeId { get; set; }
		public Guid? CategoryId { get; set; }
		public string? Name { get; set; }
		public string? Title { get; set; }
		public bool? IsCompleted { get; set; }
		public DateTime? EndOfDate { get; set; }
        public string? InstructorDescription { get; set; }
        public string? StudentDescription { get; set; }
		
		
	}
}
