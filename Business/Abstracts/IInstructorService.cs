using Business.Dtos.Requests.Instructor;
using Business.Dtos.Responses.Instructor;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IInstructorService
{
    Task<CreatedInstructorResponse> AddAsync(CreateInstructorRequest createInstructorRequest);
    Task<IPaginate<GetListInstructorResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedInstructorResponse> DeleteAsync(DeleteInstructorRequest deleteInstructorRequest);
    Task<UpdatedInstructorResponse> UpdateAsync(UpdateInstructorRequest updateInstructorRequest);
    Task<GetInstructorResponse> GetByIdAsync(GetInstructorRequest getInstructorRequest);
}