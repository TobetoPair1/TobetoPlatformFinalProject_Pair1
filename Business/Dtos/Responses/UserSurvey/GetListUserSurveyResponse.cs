namespace Business.Dtos.Responses.UserSurvey;
public class GetListUserSurveyResponse
{
        public Guid UserId { get; set; }
        public Guid SurveyId { get; set; }
        public string SurveyTitle { get; set; }

}
