using Business.Dtos.Requests.Education;
using Business.Dtos.Responses.Education;
using Business.Dtos.Responses.Exam;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IEducationService
{
    Task<CreatedEducationResponse> AddAsync(CreateEducationRequest createEducationRequest);
    Task<IPaginate<GetListEducationResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedEducationResponse> DeleteAsync(DeleteEducationRequest deletEducationResquest);
    Task<UpdatedEducationResponse> UpdateAsync(UpdateEducationRequest updateEducationRequest);
    Task<IPaginate<GetListEducationResponse>> GetListByUserIdAsync(Guid userId, PageRequest pageRequest);
    Task<GetEducationResponse> GetByIdAsync(GetEducationRequest getEducationRequest);
}
