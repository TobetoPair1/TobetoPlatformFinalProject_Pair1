namespace Business.Dtos.Responses.UserSurvey;
public class GetUserSurveyResponse
{
        public Guid UserId { get; set; }
        public Guid SurveyId { get; set; }
        public string SurveyTitle { get; set; }
}
