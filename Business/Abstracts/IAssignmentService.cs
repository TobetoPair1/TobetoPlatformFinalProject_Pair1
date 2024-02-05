using Business.Dtos.Requests.Assignment;
using Business.Dtos.Responses.Assignment;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IAssignmentService
{
    Task<CreatedAssigmentResponse> AddAsync(CreateAssigmentRequest createAssigmentRequest);
    Task<IPaginate<GetListAssigmentResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedAssigmentResponse> DeleteAsync(DeleteAssigmentRequest deleteAssigmentRequest);
    Task<UpdatedAssigmentResponse> UpdateAsync(UpdateAssigmentRequest updateAssigmentRequest);
    Task<GetAssigmentResponse> GetByIdAsync(GetAssigmentRequest getAssigmentRequest);
}