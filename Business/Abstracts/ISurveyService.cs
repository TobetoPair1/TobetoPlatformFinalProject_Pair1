using Business.Dtos.Requests.Survey;
using Business.Dtos.Requests.UserSurvey;
using Business.Dtos.Responses.Survey;
using Business.Dtos.Responses.UserSurvey;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ISurveyService
    {
        Task<CreatedSurveyResponse> AddAsync(CreateSurveyRequest createSurveyRequest);
        Task<IPaginate<GetListSurveyResponse>> GetListAsync(PageRequest pageRequest);
        Task<DeletedSurveyResponse> DeleteAsync(DeleteSurveyRequest deleteSurveyRequest);
        Task<UpdatedSurveyResponse> UpdateAsync(UpdateSurveyRequest updateSurveyRequest);
        Task<GetSurveyResponse> GetByIdAsync(GetSurveyRequest getSurveyRequest);
        Task<IPaginate<GetListSurveyResponse>> GetByUserId(Guid userId, PageRequest pageRequest);
        Task<CreatedUserSurveyResponse> AssignSurveyAsync(CreateUserSurveyRequest createUserSurveyRequest);


    }
}
