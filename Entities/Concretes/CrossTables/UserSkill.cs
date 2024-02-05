using Core.Entities;

namespace Entities.Concretes.CrossTables;

public class UserSkill : Entity<Guid>
{
    public Guid UserId { get; set; }
    public Guid SkillId { get; set; }
    public User User { get; set; }
    public Skill Skill { get; set; }
}