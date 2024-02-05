using Core.DataAccess.Repositories;
using Entities.Concretes.CrossTables;

namespace DataAccess.Abstracts;
public interface IUserSkillDal : IAsyncRepository<UserSkill, Guid>, IRepository<UserSkill, Guid>
{
}