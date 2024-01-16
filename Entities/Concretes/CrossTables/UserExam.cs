using Core.Entities;

namespace Entities.Concretes.CrossTables
{
    public class UserExam : Entity<Guid>
    {
        public Guid UserId { get; set; }
        public Guid ExamId { get; set; }
        public User User { get; set; }
        public Exam Exam { get; set; }
    }
}
