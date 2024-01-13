using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IUserOperationClaimDal : IAsyncRepository<UserOperationClaim, Guid>,IRepository<UserOperationClaim, Guid>
    {
    }
}
