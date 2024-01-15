using Core.Entities;

namespace Entities.Concretes.CrossTables
{
	public class CourseAsyncContent : Entity<Guid>
    {
        public Guid CourseId { get; set; }
        public Guid AsyncContentId { get; set; }
        public Course Course { get; set; }
        public AsyncContent AsyncContent { get; set; }
    }
}
