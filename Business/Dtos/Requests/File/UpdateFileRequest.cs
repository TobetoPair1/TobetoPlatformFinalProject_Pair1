namespace Business.Dtos.Requests.File;

public class UpdateFileRequest
{
    public Guid Id { get; set; }
	public Guid AssignmentId { get; set; }
	public Guid _UserId { get; set; }
	public string FilePath { get; set; }
    
}
