namespace Business.Dtos.Responses.File;

public class GetFileResponse
{
    public Guid FileId { get; set; }
    public Guid AssignmentId { get; set; }
    public Guid UserId { get; set; }
    public string FilePath { get; set; }
    
}
