namespace Business.Dtos.Requests.Assignment;

public class CreateAssigmentRequest
{
    public Guid CourseId { get; set; }
    public string Description { get; set; }
    public int AssignmentTime { get; set; }
    public string AssignmentType { get; set; }
    public string VideoUrl { get; set; }
}

