namespace Business.Dtos.Requests.File;

public class UpdateFileRequest
{
    public Guid FileId { get; set; }
    public string NewFilePath { get; set; }
    
}
