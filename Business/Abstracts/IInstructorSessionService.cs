using Business.Dtos.Requests.InstructorSession;
using Business.Dtos.Responses.InstructorSession;
using Business.Dtos.Responses.Session;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IInstructorSessionService
{
    Task<CreatedInstructorSessionResponse> AddAsync(CreateInstructorSessionRequest createInstructorSessionRequest);
    Task<IPaginate<GetListInstructorSessionResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedInstructorSessionResponse> DeleteAsync(DeleteInstructorSessionRequest deleteInstructorSessionRequest);
    Task<UpdatedInstructorSessionResponse> UpdateAsync(UpdateInstructorSessionRequest updateInstructorSessionRequest);
    Task<GetInstructorSessionResponse> GetByIdAsync(GetInstructorSessionRequest getInstructorSessionRequest);
    Task<IPaginate<GetListSessionResponse>> GetListByInstructorIdAsync(Guid instructorId, PageRequest pageRequest);
}