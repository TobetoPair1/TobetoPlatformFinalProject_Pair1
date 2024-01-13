using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfUserOperationClaimDal : EfRepositoryBase<UserOperationClaim, Guid, TobetoPlatformContext>, IUserOperationClaimDal
    {
        public EfUserOperationClaimDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
