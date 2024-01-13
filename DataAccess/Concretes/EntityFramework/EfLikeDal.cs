using Core.DataAccess.Repositories;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public class EfLikeDal : EfRepositoryBase<Like, Guid, TobetoPlatformContext>, ILikeDal
    {
        public EfLikeDal(TobetoPlatformContext context) : base(context)
        {
            
        }
    }
}
