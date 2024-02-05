using Core.Entities;

namespace Core.Utilities.Security.Jwt;
public interface ITokenHelper
{
    AccessToken CreateToken(IUser user, List<IOperationClaim> operationClaims);
}