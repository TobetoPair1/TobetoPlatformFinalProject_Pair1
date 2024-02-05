using Core.Entities;
using Entities.Concretes.CrossTables;

namespace Entities.Concretes;

public class Exam : Entity<Guid>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartOfDate { get; set; }
    public DateTime EndOfTime { get; set; }
    public ulong Time { get; set; }
    public bool IsCompleted { get; set; }
    public int QuestionCount { get; set; }
    public int Score { get; set; }
    public string Type { get; set; }
    public int TrueCount { get; set; }
    public int FalseCount { get; set; }
    public int EmptyCount { get; set; }
    public ICollection<ExamQuestion> Questions { get; set;}
    public ICollection<UserExam> Users { get; set;}
}