using Core.DataAccess.Repositories;
using Core.Entities;
using Entities.Concretes;

namespace DataAccess.Abstracts;
public interface IUserDal: IAsyncRepository<User,Guid>,IRepository<User,Guid>
{
    List<IOperationClaim> GetClaims(IUser user);
}