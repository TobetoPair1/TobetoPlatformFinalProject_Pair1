using Entities.Concretes.Models;

namespace Entities.Concretes;

public class Assignment : Content
{
    public Guid Id { get; set; }
    public Guid CourseId { get; set; }
    public string Description { get; set; }
    public int AssignmentTime { get; set; }
    public string AssignmentType { get; set; }
    public string VideoUrl { get; set; }
    public ICollection<File> File { get; set; }
    public Course Course { get; set; }
}
