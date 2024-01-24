namespace Business.Dtos.Requests.UserFavourite
{
	public class CreateUserFavouriteRequest
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid FavouriteId { get; set; }
    }
}
