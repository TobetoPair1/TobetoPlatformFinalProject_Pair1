using Business.Abstracts;
using Business.Dtos.Requests.Session;
using Business.Dtos.Responses.Session;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class SessionManager : ISessionService
    {
        public Task<CreatedSessionResponse> AddAsync(CreateSessionRequest createSessionRequest)
        {
            throw new NotImplementedException();
        }

        public Task<DeletedSessionResponse> DeleteAsync(DeleteSessionRequest deleteSessionRequest)
        {
            throw new NotImplementedException();
        }

        public Task<GetSessionResponse> GetByIdAsync(GetSessionRequest getSessionRequest)
        {
            throw new NotImplementedException();
        }

        public Task<IPaginate<GetListSessionResponse>> GetListAsync(PageRequest pageRequest)
        {
            throw new NotImplementedException();
        }

        public Task<UpdatedSessionResponse> UpdateAsync(UpdateSessionRequest updateSessionRequest)
        {
            throw new NotImplementedException();
        }
    }
}
