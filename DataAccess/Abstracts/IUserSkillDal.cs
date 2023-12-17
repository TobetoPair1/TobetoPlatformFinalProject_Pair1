using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	public interface IUserSkillDal : IAsyncRepository<UserSkill, Guid>, IRepository<UserSkill, Guid>
	{
	}
}
