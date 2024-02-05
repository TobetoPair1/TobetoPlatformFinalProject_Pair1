using Business.Dtos.Requests.UserSurvey;
using Business.Dtos.Responses.Survey;
using Business.Dtos.Responses.UserSurvey;
using Core.DataAccess.Paging;

namespace Business.Abstracts;
public interface IUserSurveyService
{
    Task<CreatedUserSurveyResponse> AddAsync(CreateUserSurveyRequest createUserSurveyRequest);
    Task<DeletedUserSurveyResponse> DeleteAsync(DeleteUserSurveyRequest deleteUserSurveyRequest);
    Task<GetUserSurveyResponse> GetByIdAsync(GetUserSurveyRequest getUserSurveyRequest);
    Task<IPaginate<GetListUserSurveyResponse>> GetListAsync(PageRequest pageRequest);
    Task<IPaginate<GetListSurveyResponse>> GetListByUserIdAsync(Guid userId, PageRequest pageRequest);
}