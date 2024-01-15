namespace Business.Dtos.Responses.UserApplication;
public class GetListUserApplicationResponse
{
        public Guid UserId { get; set; }
        public Guid ApplicationId { get; set; }
        public string ApplicationTitle { get; set; }
}
