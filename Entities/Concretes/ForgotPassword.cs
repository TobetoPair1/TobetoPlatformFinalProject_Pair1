using Core.Entities;
namespace Entities.Concretes;

public class ForgotPassword:Entity<Guid>
{
    public Guid UserId { get; set; }
    public string Code { get; set; }
    public User User { get; set; }
}