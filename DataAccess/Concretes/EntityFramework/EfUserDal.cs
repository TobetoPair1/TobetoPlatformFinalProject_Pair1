using Core.DataAccess.Repositories;
using Core.Entities;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;
public class EfUserDal : EfRepositoryBase<User, Guid, TobetoPlatformContext>, IUserDal
{
    TobetoPlatformContext _context;
    public EfUserDal(TobetoPlatformContext context) : base(context)
    {
        _context = context;
    }

    public List<IOperationClaim> GetClaims(IUser user)
    {
        
         var result = from operationClaim in _context.OperationClaims
                      join userOperationClaim in _context.UserOperationClaims
                      on operationClaim.Id equals userOperationClaim.OperationClaimId
                      where userOperationClaim.UserId == user.Id
                      select (IOperationClaim)(new OperationClaim {Id=operationClaim.Id,  Name = operationClaim.Name });				
         return result.ToList();
    }
}