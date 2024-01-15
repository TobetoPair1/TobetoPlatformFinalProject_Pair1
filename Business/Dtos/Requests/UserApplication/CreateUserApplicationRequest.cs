namespace Business.Dtos.Requests.UserApplication;
public class CreateUserApplicationRequest
{
    public Guid UserId { get; set; }
    public Guid ApplicationId { get; set; }
}
