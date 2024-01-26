namespace Business.Dtos.Responses.Assignment
{
    public class DeletedAssigmentResponse
    {
		public Guid Id { get; set; }
		public string CourseName { get; set; }
		public string CategoryName { get; set; }
		public int LikeCount { get; set; }
		public string VideoUrl { get; set; }
		public string Name { get; set; }
		public string Title { get; set; }
		public bool IsCompleted { get; set; }
		public string Description { get; set; }
		public int AssignmentTime { get; set; }
		public string AssignmentType { get; set; }
	}
}
