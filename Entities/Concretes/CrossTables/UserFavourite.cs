using Core.Entities;

namespace Entities.Concretes.CrossTables
{
    public class UserFavourite : Entity<Guid>
    {
        public Guid UserId { get; set; }
        public Guid FavouriteId { get; set; }
        public User User { get; set; }
        public Favourite Favourite { get; set; }
    }
}
