using Core.Entities;

namespace Entities.Concretes
{
	public class Calendar : Entity<Guid>
	{
		public Guid UserId { get; set; }
		public Guid InstructorId { get; set; }
		public Guid CourseId { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsPurchased { get; set; }
        public DateTime Date {  get; set; }
        public Course Course { get; set; }
		public Instructor Instructor { get; set; }
		public ICollection<User> User { get; set; }
	}
}
