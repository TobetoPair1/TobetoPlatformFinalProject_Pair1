namespace Business.Dtos.Responses.User
{
	public class CreatedUserResponse
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsInstructor { get; set; }
    }
}
