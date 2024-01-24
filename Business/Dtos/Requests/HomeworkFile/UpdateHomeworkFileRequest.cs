namespace Business.Dtos.Requests.HomeworkFile;

public class UpdateHomeworkFileRequest
{
    public Guid FileId { get; set; }
    public Guid HomeworkId { get; set; }
}
