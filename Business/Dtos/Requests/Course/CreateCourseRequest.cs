namespace Business.Dtos.Requests.Course;

public class CreateCourseRequest
{
    public Guid CategoryId { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public DateTime StartOfDate { get; set; }
    public DateTime EndOfDate { get; set; }
    public ulong TimeSpent { get; set; }
    public ulong EstimatedTime { get; set; }
    public int ContentCount { get; set; }
    public string ProducingCompany { get; set; }
}
