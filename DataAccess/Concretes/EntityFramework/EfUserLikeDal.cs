using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes.CrossTables;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfUserLikeDal : EfRepositoryBase<UserLike, Guid, TobetoPlatformContext>, IUserLikeDal
    {
        public EfUserLikeDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
