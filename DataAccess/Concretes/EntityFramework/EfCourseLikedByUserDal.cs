using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes.CrossTables;

namespace DataAccess.Concretes.EntityFramework
{
	public class EfCourseLikedByUserDal : EfRepositoryBase<CourseLikedByUser, Guid, TobetoPlatformContext>, ICourseLikedByUserDal
	{
		public EfCourseLikedByUserDal(TobetoPlatformContext context) : base(context)
		{
		}
	}
}
