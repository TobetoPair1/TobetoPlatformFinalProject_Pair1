namespace Business.Dtos.Requests.Survey
{
	public class UpdateSurveyRequest
    {
        public Guid Id;
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? FormUrl { get; set; }
    }
}
