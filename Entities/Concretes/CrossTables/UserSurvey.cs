using Core.Entities;

namespace Entities.Concretes.CrossTables;

public class UserSurvey : Entity<Guid>
{
    public Guid UserId { get; set; }
    public Guid SurveyId { get; set; }
    public User User { get; set; }
    public Survey Survey { get; set; }
}