using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
	public class EfPersonalInfoDal : EfRepositoryBase<PersonalInfo, Guid, TobetoPlatformContext>, IPersonalInfoDal
	{
		public EfPersonalInfoDal(TobetoPlatformContext context) : base(context)
		{

		}
	}
}
