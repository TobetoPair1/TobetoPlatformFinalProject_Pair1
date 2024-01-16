using Business.Dtos.Requests.Experience;
using Business.Dtos.Responses.Experience;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IExperienceService
{
    Task<CreatedExperienceResponse> AddAsync(CreateExperienceRequest createExperienceRequest);
    Task<IPaginate<GetListExperienceResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedExperienceResponse> DeleteAsync(DeleteExperienceRequest deleteExperienceResquest);
    Task<UpdatedExperienceResponse> UpdateAsync(UpdateExperienceRequest updateExperienceRequest);
    Task<GetExperienceResponse> GetByIdAsync(GetExperienceRequest getExperienceRequest);
}
