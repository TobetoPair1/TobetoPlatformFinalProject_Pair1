namespace Business.Dtos.Requests.UserSurvey;
public class DeleteUserSurveyRequest
{
        public Guid UserId { get; set; }
        public Guid SurveyId { get; set; }
}
