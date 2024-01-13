using Core.DataAccess.Repositories;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public class EfLiveContentDal : EfRepositoryBase<LiveContent, Guid, TobetoPlatformContext>, ILiveContentDal
    {
        public EfLiveContentDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
