using Core.DataAccess.Repositories;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public class EfApplicationDal : EfRepositoryBase<Application, Guid, TobetoPlatformContext>, IApplicationDal
    {
        public EfApplicationDal(TobetoPlatformContext context) : base(context)
        {
            
        }
    }
}
