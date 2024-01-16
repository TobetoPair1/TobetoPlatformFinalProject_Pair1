using Core.Entities;

namespace Entities.Concretes
{
    public class Session:Entity<Guid>
    {
        public Guid LiveContentId { get; set; }
        public string RecordUrl { get; set; }
        public string SessionLinkUrl { get; set; }
        public DateTime StartOfTime { get; set; }
        public DateTime EndOfTime { get; set; }
        public ICollection<Instructor> Instructors { get; set; }
        public LiveContent LiveContent { get; set; }
    }
}