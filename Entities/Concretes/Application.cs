using Core.Entities;

using Entities.Concretes.CrossTables;

namespace Entities.Concretes
{
    public class Application : Entity<Guid>
    {
        public string Title { get; set; }
        public string FormUrl { get; set; }
        public string State { get; set; }
        public ICollection<UserApplication> Users { get; set; }
    }
}
