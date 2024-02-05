using Core.Entities;
using Entities.Concretes.CrossTables;

namespace Entities.Concretes;

public class Homework : Entity<Guid>
{
    public Guid CourseId { get; set; }
    public Guid LiveContentId { get; set; }
    public DateTime EndOfDate { get; set; }
	public string Name { get; set; }
	public string InstructorDescription { get; set; }
    public string StudentDescription { get; set; }
    public bool IsCompleted { get; set; }
    public ICollection<HomeworkFile> Files { get; set; }
    public Course Course { get; set; }
    public LiveContent LiveContent { get; set; }
}