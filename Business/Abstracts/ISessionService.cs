using Business.Dtos.Requests.InstructorSession;
using Business.Dtos.Requests.Session;
using Business.Dtos.Responses.InstructorSession;
using Business.Dtos.Responses.Session;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface ISessionService
{
    Task<CreatedSessionResponse> AddAsync(CreateSessionRequest createSessionRequest);
    Task<IPaginate<GetListSessionResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedSessionResponse> DeleteAsync(DeleteSessionRequest deleteSessionRequest);
    Task<UpdatedSessionResponse> UpdateAsync(UpdateSessionRequest updateSessionRequest);
    Task<GetSessionResponse> GetByIdAsync(GetSessionRequest getSessionRequest);
    Task<IPaginate<GetListSessionResponse>> GetListByInstructorIdAsync(Guid instructorId, PageRequest pageRequest);
    Task<CreatedInstructorSessionResponse> AssignSessionAsync(CreateInstructorSessionRequest createInstructorSessionRequest);
}