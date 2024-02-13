namespace Business.Dtos.Requests.ForgotPassword;
public class CreateForgotPasswordRequest
{
    public Guid UserId { get; set; }
    public string Code { get; set; }
}