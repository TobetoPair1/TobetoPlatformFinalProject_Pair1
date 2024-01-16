using Business.Dtos.Requests.Education;
using Business.Dtos.Responses.Education;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IEducationService
{
    Task<CreatedEducationResponse> AddAsync(CreateEducationRequest createEducationRequest);
    Task<IPaginate<GetListEducationResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedEducationResponse> DeleteAsync(DeleteEducationRequest deletEducationResquest);
    Task<UpdatedEducationResponse> UpdateAsync(UpdateEducationRequest updateEducationRequest);
    Task<GetEducationResponse> GetByIdAsync(GetEducationRequest getEducationRequest);
}
