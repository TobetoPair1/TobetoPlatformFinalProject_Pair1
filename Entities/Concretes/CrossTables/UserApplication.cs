using Core.Entities;

namespace Entities.Concretes.CrossTables
{
    public class UserApplication : Entity<Guid>
    {
        public Guid UserId { get; set; }
        public Guid ApplicationId { get; set; }
        public User User { get; set; }
        public Application Application { get; set; }
    }
}
