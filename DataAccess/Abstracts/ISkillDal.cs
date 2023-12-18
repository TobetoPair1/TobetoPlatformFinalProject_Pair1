using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	public interface ISkillDal : IAsyncRepository<Skill, Guid>, IRepository<Skill, Guid>
	{
	}
}
