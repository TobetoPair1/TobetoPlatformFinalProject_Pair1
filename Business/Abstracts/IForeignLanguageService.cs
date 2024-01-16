using Business.Dtos.Requests.ForeignLanguage;
using Business.Dtos.Responses.ForeignLanguage;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IForeignLanguageService
{
	Task<CreatedForeignLanguageResponse> AddAsync(CreateForeignLanguageRequest createForeignLanguageRequest);
	Task<IPaginate<GetListForeignLanguageResponse>> GetListAsync(PageRequest pageRequest);
	Task<DeletedForeignLanguageResponse> DeleteAsync(DeleteForeignLanguageRequest deleteForeignLanguageRequest);
	Task<UpdatedForeignLanguageResponse> UpdateAsync(UpdateForeignLanguageRequest updateForeignLanguageRequest);
	Task<GetForeignLanguageResponse> GetByIdAsync(GetForeignLanguageRequest getForeignLanguageRequest);
}
