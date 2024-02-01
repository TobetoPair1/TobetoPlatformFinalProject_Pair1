using Core.Entities;

namespace Entities.Concretes;

public class Assignment : Entity<Guid>
{
	public string Name { get; set; }
	public string Title { get; set; }
	public bool IsCompleted { get; set; }	
	public Guid CourseId { get; set; }
    public string Description { get; set; }
    public int AssignmentTime { get; set; }
    public string AssignmentType { get; set; }
    public string VideoUrl { get; set; }
    public ICollection<File> Files { get; set; }
    public Course Course { get; set; }
}
