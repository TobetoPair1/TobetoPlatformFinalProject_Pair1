using Core.Entities;
using Entities.Concretes.CrossTables;

namespace Entities.Concretes;

public class Skill:Entity<Guid>
{
    public string Name { get; set; }
	public ICollection<UserSkill> Users { get; set; }
}