namespace Business.Dtos.Requests.HomeworkFile;

public class DeleteHomeworkFileRequest
{
    //public Guid Id { get; set; }
    public Guid FileId { get; set; }
    public Guid HomeworkId { get; set; }
}
