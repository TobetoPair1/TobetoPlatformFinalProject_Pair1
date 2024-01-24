namespace Business.Dtos.Requests.UserFavourite
{
	public class UpdateUserFavouriteRequest
    {       
        public Guid UserId { get; set; }
        public Guid FavouriteId { get; set; }
    }
}
