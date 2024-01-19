using Core.Entities;
using Entities.Concretes.CrossTables;

namespace Entities.Concretes
{
    public class Instructor:Entity<Guid>
    {
        public string FullName { get; set; }
        public ICollection<InstructorSession> Sessions { get; set; }
    }
}