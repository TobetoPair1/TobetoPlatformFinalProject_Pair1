namespace Business.Dtos.Requests.ContentLikedByUser
{
	public class CreateContentLikedByUserRequest
	{
		public Guid UserId { get; set; }
		public Guid ContentId { get; set; }
	}
}
