using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfSessionDal : EfRepositoryBase<Session, Guid, TobetoPlatformContext>, ISessionDal
    {
        public EfSessionDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
