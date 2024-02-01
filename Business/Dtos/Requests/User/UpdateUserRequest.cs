namespace Business.Dtos.Requests.User
{
	public class UpdateUserRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}