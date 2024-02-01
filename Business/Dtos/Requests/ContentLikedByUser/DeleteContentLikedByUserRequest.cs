namespace Business.Dtos.Requests.ContentLikedByUser
{
	public class DeleteContentLikedByUserRequest
	{
		public Guid UserId { get; set; }
		public Guid ContentId { get; set; }
	}
}
