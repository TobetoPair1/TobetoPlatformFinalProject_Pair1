namespace Business.Dtos.Requests.User
{
	public class UpdateUserRequest
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool? IsInstructor { get; set; }
    }
}
