using Business.Dtos.Requests.User;
using Business.Dtos.Responses.User;
using Core.DataAccess.Paging;
using Core.Entities;
using Entities.Concretes;

namespace Business.Abstracts;
public interface IUserService
{
    Task<CreatedUserResponse> AddAsync(CreateUserRequest createUserRequest);
    Task<IPaginate<GetListUserResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedUserResponse> DeleteByIdAsync(Guid id);
    Task<DeletedUserResponse> DeleteByMailAsync(string email);
    Task<UpdatedUserResponse> UpdateAsync(UpdateUserRequest updateUserRequest);
    Task<GetUserResponse> GetByIdAsync(Guid id);
    Task<User> GetByMailAsync(string mail,bool withDeleted);
    Task<GetByMailUserResponse> GetByMailUserAsync(string mail);
    List<IOperationClaim> GetClaims(IUser user);
    Task<bool> ActivateUserAsync(string email);
}