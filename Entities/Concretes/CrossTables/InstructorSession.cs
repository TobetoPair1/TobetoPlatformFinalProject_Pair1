using Core.Entities;

namespace Entities.Concretes.CrossTables
{
	public class InstructorSession : Entity<Guid>
	{
		public Guid InstructorId { get; set; }
		public Guid SessionId { get; set; }
		public Instructor Instructor { get; set; }
		public Session Session { get; set; }
	}
}