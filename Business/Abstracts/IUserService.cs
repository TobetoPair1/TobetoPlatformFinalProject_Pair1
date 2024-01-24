using Business.Dtos.Requests.User;
using Business.Dtos.Responses.User;
using Business.Dtos.Responses.UserCourse;
using Core.DataAccess.Paging;
using Business.Dtos.Requests.UserCourse;
using Business.Dtos.Responses.Course;
using Core.Entities;
using Entities.Concretes;

namespace Business.Abstracts
{
	public interface IUserService
    {
        Task<CreatedUserResponse> AddAsync(CreateUserRequest createUserRequest);
        Task<CreatedUserCourseResponse> AssignCourseAsync(CreateUserCourseRequest createUserCourseRequest);
        Task<IPaginate<GetListUserResponse>> GetListAsync(PageRequest pageRequest);
        Task<DeletedUserResponse> DeleteAsync(DeleteUserRequest deleteUserRequest);
        Task<UpdatedUserResponse> UpdateAsync(UpdateUserRequest updateUserRequest);
        Task<GetUserResponse> GetByIdAsync(Guid? id);
        Task<User> GetByMailAsync(string mail,bool withDeleted);
        List<IOperationClaim> GetClaims(IUser user);
        Task<bool> ActivateUserAsync(string email);
		Task<IPaginate<GetListCourseResponse>> GetCourses(Guid userId,PageRequest pageRequest);
	}
}
