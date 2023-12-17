using Business.Dtos.Requests.Experience;
using Business.Dtos.Responses.Experience;
using Business.Dtos.Responses.PersonalInfo;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IExperienceService
    {
        Task<CreatedExperienceResponse> AddAsync(CreateExperienceRequest createExperienceRequest);
        Task<IPaginate<GetListExperienceResponse>> GetListAsync(PageRequest pageRequest);
        Task<DeletedExperienceResponse> DeleteAsync(DeleteExperienceRequest deleteExperienceResquest);
        Task<UpdatedExperienceResponse> UpdateAsync(UpdateExperienceRequest updateExperienceRequest);
        Task<GetExperienceResponse> GetByIdAsync(GetExperienceRequest getExperienceRequest);
    }
}
