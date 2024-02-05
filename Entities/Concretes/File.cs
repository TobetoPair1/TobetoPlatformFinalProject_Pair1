using Core.Entities;
using Entities.Concretes.CrossTables;

namespace Entities.Concretes;

public class File : Entity<Guid>
{
    public Guid AssignmentId { get; set; }
    public Guid UserId { get; set; }
    public string FilePath { get; set; }
    public ICollection<HomeworkFile> Homeworks { get; set; }
    public User User { get; set; }
    public Assignment Assignment { get; set; }
}