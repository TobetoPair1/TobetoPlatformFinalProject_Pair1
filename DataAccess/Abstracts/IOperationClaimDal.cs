using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IOperationClaimDal : IAsyncRepository<OperationClaim, Guid>, IRepository<OperationClaim, Guid>
    {
    }
}
