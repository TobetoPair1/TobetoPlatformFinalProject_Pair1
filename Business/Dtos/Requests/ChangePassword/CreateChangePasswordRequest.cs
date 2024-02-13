namespace Business.Dtos.Requests.ChangePassword;

public class CreateChangePasswordRequest
{
    public string Mail { get; set; }
    public string Password { get; set; }
}