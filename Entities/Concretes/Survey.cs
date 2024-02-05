using Core.Entities;
using Entities.Concretes.CrossTables;

namespace Entities.Concretes;

public class Survey : Entity<Guid>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string FormUrl { get; set; }
    public ICollection<UserSurvey> Users { get; set; }
}