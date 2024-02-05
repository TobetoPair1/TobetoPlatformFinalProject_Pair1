using Core.Entities;

namespace Entities.Concretes;

public class SocialMedia:Entity<Guid>
{
    public Guid UserId { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public User User { get; set; }
}