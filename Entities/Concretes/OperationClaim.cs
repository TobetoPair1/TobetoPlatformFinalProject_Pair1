using Core.Entities;

namespace Entities.Concretes;
public class OperationClaim : Entity<Guid>, IOperationClaim
{
    public string Name { get; set; }
    public ICollection<UserOperationClaim> Users { get; set; }
}