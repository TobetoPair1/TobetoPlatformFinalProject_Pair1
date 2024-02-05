using Core.Entities;

namespace Entities.Concretes;

public class Favourite : Entity<Guid>
{
    public Guid CourseId { get; set; }
    public int Count { get; set; }
    public Course Course { get; set; }
}