using Business.Dtos.Requests.Instructor;
using Business.Dtos.Requests.Session;
using Business.Dtos.Responses.Instructor;
using Business.Dtos.Responses.Session;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ISessionService
    {
        Task<CreatedSessionResponse> AddAsync(CreateSessionRequest createSessionRequest);
        Task<IPaginate<GetListSessionResponse>> GetListAsync(PageRequest pageRequest);
        Task<DeletedSessionResponse> DeleteAsync(DeleteSessionRequest deleteSessionRequest);
        Task<UpdatedSessionResponse> UpdateAsync(UpdateSessionRequest updateSessionRequest);
        Task<GetSessionResponse> GetByIdAsync(GetSessionRequest getSessionRequest);
    }
}
