namespace Business.Dtos.Requests.HomeworkFile;

public class CreateHomeworkFileRequest
{
    public Guid FileId { get; set; }
    public Guid HomeworkId { get; set; }
}
