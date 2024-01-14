using Business.Dtos.Requests.Announcement;
using Business.Dtos.Requests.Survey;
using Business.Dtos.Responses.Announcement;
using Business.Dtos.Responses.Survey;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
