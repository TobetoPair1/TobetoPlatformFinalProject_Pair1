using Core.Entities;

namespace Entities.Concretes;

public class Category:Entity<Guid>
{
    public string Name { get; set; }
    public ICollection<Course> Courses { get; set; }
    public ICollection<LiveContent> LiveContents { get; set; }
    public ICollection<AsyncContent> AsyncContents { get; set; }
    public ICollection<Assignment> Assignments { get; set; }
}