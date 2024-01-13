using Core.DataAccess.Repositories;
using DataAccess.Contexts;
using Entities.Concretes.CrossTables;

namespace DataAccess.Abstracts
{
    public class EfUserLikeDal : EfRepositoryBase<UserLike, Guid, TobetoPlatformContext>, IUserLikeDal
    {
        public EfUserLikeDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
