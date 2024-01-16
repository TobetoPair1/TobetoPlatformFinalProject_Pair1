using Core.Entities;

namespace Entities.Concretes.CrossTables
{
    public class UserLike : Entity<Guid>
    {
        public Guid UserId { get; set; }
        public Guid LikeId { get; set; }
        public User User { get; set; }
        public Like Like { get; set; }
    }
}
