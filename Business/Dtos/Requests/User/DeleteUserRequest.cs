namespace Business.Dtos.Requests.User
{
	public class DeleteUserRequest
    {
		public Guid? Id { get; set; }
		public string? Email { get; set; }
	}
}