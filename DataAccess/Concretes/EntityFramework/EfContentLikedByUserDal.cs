using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes.CrossTables;

namespace DataAccess.Concretes.EntityFramework
{
	public class EfContentLikedByUserDal : EfRepositoryBase<ContentLikedByUser, Guid, TobetoPlatformContext>, IContentLikedByUserDal
	{
		public EfContentLikedByUserDal(TobetoPlatformContext context) : base(context)
		{
		}
	}
}
