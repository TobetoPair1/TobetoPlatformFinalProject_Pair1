using Core.DataAccess.Repositories;
using DataAccess.Contexts;
using Entities.Concretes.CrossTables;

namespace DataAccess.Abstracts
{
    public class EfUserFavouriteDal : EfRepositoryBase<UserFavourite, Guid, TobetoPlatformContext>, IUserFavouriteDal
    {        
        public EfUserFavouriteDal(TobetoPlatformContext context) : base(context)
        {            
        }
    }    
}
