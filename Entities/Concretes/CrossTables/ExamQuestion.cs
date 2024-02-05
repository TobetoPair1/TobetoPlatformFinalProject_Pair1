using Core.Entities;

namespace Entities.Concretes.CrossTables;

public class ExamQuestion : Entity<Guid>
{
    public Guid ExamId { get; set; }
    public Guid QuestionId { get; set; }
    public Exam Exam { get; set; }
    public Question Question { get; set; }
}