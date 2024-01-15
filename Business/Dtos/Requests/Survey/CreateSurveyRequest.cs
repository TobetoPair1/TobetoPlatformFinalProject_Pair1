namespace Business.Dtos.Requests.Survey;

public class CreateSurveyRequest
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string FormUrl { get; set; }
}
