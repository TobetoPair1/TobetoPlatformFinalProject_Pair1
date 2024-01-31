namespace Business.Dtos.Requests.Assignment;

public class CreateAssigmentRequest
{
    public Guid CourseId { get; set; }
	public string VideoUrl { get; set; }
	public string Name { get; set; }
	public string Title { get; set; }
	public bool IsCompleted { get; set; }
	public string Description { get; set; }
    public int AssignmentTime { get; set; }
    public string AssignmentType { get; set; }
  
}

