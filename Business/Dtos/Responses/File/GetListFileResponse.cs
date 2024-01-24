namespace Business.Dtos.Responses.File;

public class GetListFileResponse
{
    public Guid Id { get; set; }
    public Guid AssignmentId { get; set; }
    public Guid UserId { get; set; }
    public string FilePath { get; set; }
}
