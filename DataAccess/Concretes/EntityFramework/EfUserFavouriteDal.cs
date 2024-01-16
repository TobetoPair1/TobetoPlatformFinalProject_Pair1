using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes.CrossTables;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfUserFavouriteDal : EfRepositoryBase<UserFavourite, Guid, TobetoPlatformContext>, IUserFavouriteDal
    {
        public EfUserFavouriteDal(TobetoPlatformContext context) : base(context)
        {
            
        }
    }
}
