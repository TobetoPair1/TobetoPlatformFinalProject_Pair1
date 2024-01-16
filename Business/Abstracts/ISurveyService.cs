using Business.Dtos.Requests.Survey;
using Business.Dtos.Responses.Survey;
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
    }
}
