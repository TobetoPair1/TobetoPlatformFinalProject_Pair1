using Core.Entities;

namespace Entities.Concretes
{
    public class Announcement : Entity<Guid>
    {
        public string Header { get; set; }
        public string Description { get; set; }
    }
}