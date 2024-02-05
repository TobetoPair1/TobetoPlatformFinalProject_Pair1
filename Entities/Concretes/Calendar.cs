using Core.Entities;
using Entities.Concretes.CrossTables;

namespace Entities.Concretes;

public class Calendar : Entity<Guid>
{
	public Guid InstructorId { get; set; }
	public Guid CourseId { get; set; }
    public bool IsCompleted { get; set; }
    public bool IsPurchased { get; set; }
    public DateTime Date {  get; set; }
    public Course Course { get; set; }
	public Instructor Instructor { get; set; }
	public ICollection<UserCalendar> Users { get; set; }
}