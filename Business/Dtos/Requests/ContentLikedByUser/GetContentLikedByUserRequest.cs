namespace Business.Dtos.Requests.ContentLikedByUser
{
	public class GetContentLikedByUserRequest
	{
		public Guid UserId { get; set; }
		public Guid ContentId { get; set; }
	}
}
