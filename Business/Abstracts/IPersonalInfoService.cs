using Business.Dtos.Requests.PersonalInfo;
using Business.Dtos.Responses.PersonalInfo;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IPersonalInfoService
{
    Task<CreatedPersonalInfoResponse> AddAsync(CreatePersonalInfoRequest createPersonalInfoRequest);
    Task<IPaginate<GetListPersonalInfoResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedPersonalInfoResponse> DeleteAsync(DeletePersonalInfoRequest deletePersonalInfoRequest);
    Task<UpdatedPersonalInfoResponse> UpdateAsync(UpdatePersonalInfoRequest updatePersonalInfoRequest);
    Task<GetPersonalInfoResponse> GetByIdAsync(GetPersonalInfoRequest getPersonalInfoRequest);
    Task<GetPersonalInfoResponse> GetByUserIdAsync(GetPersonalInfoRequest getPersonalInfoRequest);
}
