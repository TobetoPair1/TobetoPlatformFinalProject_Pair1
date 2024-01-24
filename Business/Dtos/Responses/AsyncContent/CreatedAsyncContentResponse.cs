namespace Business.Dtos.Responses.AsyncContent;

public class CreatedAsyncContentResponse
{
	public Guid Id { get; set; }
	public string VideoUrl { get; set; }
    public string Language { get; set; }
    public string SubType { get; set; }
    public string Company { get; set; }
    public string Description { get; set; }
    public int LikeCount { get; set; }
    public string Name { get; set; }
    public string CategoryName { get; set; }
    public string Title { get; set; }
    public bool IsCompleted { get; set; }
}