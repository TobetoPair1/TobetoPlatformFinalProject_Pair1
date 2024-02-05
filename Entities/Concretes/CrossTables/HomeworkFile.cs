using Core.Entities;

namespace Entities.Concretes.CrossTables;

public class HomeworkFile : Entity<Guid>
{
    public Guid FileId { get; set; }
    public Guid HomeworkId { get; set; }
    public File File { get; set; }
    public Homework Homework { get; set; }
}