namespace Business.Dtos.Requests.ContentLikedByUser
{
	public class GetListContentLikedByUserRequest
	{
		public Guid UserId { get; set; }
		public Guid ContentId { get; set; }
	}
}
