using Business.Dtos.Requests.AsyncContent;
using Business.Dtos.Responses.AsyncContent;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IAsyncContentService
{
    Task<CreatedAsyncContentResponse> AddAsync(CreateAsyncContentRequest createAsyncContentRequest);
    Task<IPaginate<GetListAsyncContentResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedAsyncContentResponse> DeleteAsync(DeleteAsyncContentRequest deleteAsyncContentRequest);
    Task<UpdatedAsyncContentResponse> UpdateAsync(UpdateAsyncContentRequest updateAsyncContentRequest);
    Task<GetAsyncContentResponse> GetByIdAsync(GetAsyncContentRequest getAsyncContentRequest);
}