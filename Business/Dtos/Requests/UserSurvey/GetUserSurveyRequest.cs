namespace Business.Dtos.Requests.UserSurvey;
public class GetUserSurveyRequest
{
        public Guid UserId { get; set; }
        public Guid SurveyId { get; set; }
}
