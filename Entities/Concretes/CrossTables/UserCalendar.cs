using Core.Entities;

namespace Entities.Concretes.CrossTables
{
    public class UserCalendar : Entity<Guid>
    {
        public Guid UserId { get; set; }
        public Guid CalenderId { get; set; }
        public User User { get; set; }
        public Calendar Calendar { get; set; }
    }
}