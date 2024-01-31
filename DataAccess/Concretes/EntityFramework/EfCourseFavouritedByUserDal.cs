using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes.CrossTables;

namespace DataAccess.Concretes.EntityFramework
{
	public class EfCourseFavouritedByUserDal : EfRepositoryBase<CourseFavouritedByUser, Guid, TobetoPlatformContext>, ICourseFavouritedByUser
	{
		public EfCourseFavouritedByUserDal(TobetoPlatformContext context) : base(context)
		{
		}
	}
}
