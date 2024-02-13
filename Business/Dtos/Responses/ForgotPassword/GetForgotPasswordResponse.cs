namespace Business.Dtos.Responses.ForgotPassword;

public class GetForgotPasswordResponse
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Code { get; set; }
}