using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
	public class EfHomeworkDal : EfRepositoryBase<Homework, Guid, TobetoPlatformContext>, IHomeworkDal
	{
		public EfHomeworkDal(TobetoPlatformContext context) : base(context)
		{
		}
	}
}
