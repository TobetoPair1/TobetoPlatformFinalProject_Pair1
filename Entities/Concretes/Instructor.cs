using Core.Entities;

namespace Entities.Concretes
{
    public class Instructor:Entity<Guid>
    {
        public string FullName { get; set; }
        public ICollection<Session> Sessions { get; set; }
    }
}