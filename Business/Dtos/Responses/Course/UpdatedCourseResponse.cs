namespace Business.Dtos.Responses.Course;

public class UpdatedCourseResponse
{
    public Guid Id { get; set; }
    public Guid CategoryId { get; set; }
    public Guid LikeId { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public DateTime StartOfDate { get; set; }
    public DateTime EndOfDate { get; set; }
    public TimeSpan TimeSpent { get; set; }
    public TimeSpan EstimatedTime { get; set; }
    public int ContentCount { get; set; }
    public string ProducingCompany { get; set; }
}
