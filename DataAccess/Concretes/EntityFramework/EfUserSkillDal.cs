using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes.CrossTable;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfUserSkillDal : EfRepositoryBase<UserSkill, Guid, TobetoPlatformContext>, IUserSkillDal
	{
		public EfUserSkillDal(TobetoPlatformContext context) : base(context)
		{
		}
	}
}
