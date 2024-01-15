namespace Business.Dtos.Responses.File;

public class GetListFileResponse
{
    public List<FileListItem> Files { get; set; }
}

public class FileListItem
{
    public Guid FileId { get; set; }
    public Guid AssignmentId { get; set; }
    public Guid UserId { get; set; }
    public string FilePath { get; set; }
}
