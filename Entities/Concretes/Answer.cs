using Core.Entities;

namespace Entities.Concretes
{
    public class Answer : Entity<Guid>
    {
        public Guid QuestionId { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Question Question { get; set; }
    }
}
