using Core.Entities;

namespace Entities.Concretes;

public class ForeignLanguage:Entity<Guid>
{
    public Guid UserId { get; set; }
    public string Name { get; set; }
    public string Level { get; set; }
    public User User { get; set; }
}