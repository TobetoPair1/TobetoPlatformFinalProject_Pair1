using Core.Entities;

namespace Entities.Concretes.CrossTables;

public class CourseLiveContent : Entity<Guid>
{
    public Guid CourseId { get; set; }
    public Guid LiveContentId { get; set; }
    public Course Course { get; set; }
    public LiveContent LiveContent { get; set; }
}