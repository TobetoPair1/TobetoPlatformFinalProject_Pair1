using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;
public class EfOperationClaimDal : EfRepositoryBase<OperationClaim, Guid, TobetoPlatformContext>, IOperationClaimDal
{
    public EfOperationClaimDal(TobetoPlatformContext context) : base(context)
    {
    }
}