using Core.Entities;

namespace Entities.Concretes.Models
{
	public class Content : Entity<Guid>
    {
        public Guid LikeId { get; set; }
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public Category Category { get; set; }
        public Like Like { get; set; }
    }
}