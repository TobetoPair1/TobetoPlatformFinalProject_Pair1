namespace Business.Dtos.Requests.Auth
{
	public class RegisterRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[]? _passwordHash;
        public byte[]? _passwordSalt;
    }
}
