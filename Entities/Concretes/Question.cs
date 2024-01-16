using Core.Entities;
using Entities.Concretes.CrossTables;

namespace Entities.Concretes
{
    public class Question : Entity<Guid>
    {        
        public Guid TrueAnswerId { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public ICollection<ExamQuestion> Exams { get; set; }
    }
}