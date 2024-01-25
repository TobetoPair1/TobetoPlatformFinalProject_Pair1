using Business.Dtos.Requests.UserExam;
using Business.Dtos.Responses.Exam;
using Business.Dtos.Responses.UserExam;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IUserExamService
{
    Task<CreatedUserExamResponse> AddAsync(CreateUserExamRequest createUserExamRequest);
    Task<DeletedUserExamResponse> DeleteAsync(DeleteUserExamRequest deleteUserExamRequest);
    Task<GetUserExamResponse> GetByIdAsync(GetUserExamRequest getUserExamRequest);
    Task<IPaginate<GetListUserExamResponse>> GetListAsync(PageRequest pageRequest);
    Task<IPaginate<GetListExamResponse>> GetListByUserIdAsync(Guid userId, PageRequest pageRequest);

}
