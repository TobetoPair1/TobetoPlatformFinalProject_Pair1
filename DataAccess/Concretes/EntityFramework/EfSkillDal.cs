using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;
public class EfSkillDal : EfRepositoryBase<Skill, Guid, TobetoPlatformContext>, ISkillDal
{
	public EfSkillDal(TobetoPlatformContext context) : base(context)
	{
	}
}