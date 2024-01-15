namespace Business.Dtos.Requests.UserApplication;
public class DeleteUserApplicationRequest
{
        public Guid UserId { get; set; }
        public Guid ApplicationId { get; set; }
}
