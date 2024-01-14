namespace Business.Dtos.Requests.File;

public class CreateFileRequest
{
    public Guid AssignmentId { get; set; }
    public Guid UserId { get; set; }
    public string FilePath { get; set; }
}
