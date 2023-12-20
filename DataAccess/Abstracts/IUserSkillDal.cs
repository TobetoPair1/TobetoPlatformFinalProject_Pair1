using Core.DataAccess.Repositories;
using Entities.Concretes.CrossTable;

namespace DataAccess.Abstracts
{
    public interface IUserSkillDal : IAsyncRepository<UserSkill, Guid>, IRepository<UserSkill, Guid>
	{
	}
}
