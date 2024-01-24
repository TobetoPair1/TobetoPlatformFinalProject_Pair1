namespace Business.Dtos.Requests.HomeworkFile;

public class DeleteHomeworkFileRequest
{   
    public Guid FileId { get; set; }
    public Guid HomeworkId { get; set; }
}
