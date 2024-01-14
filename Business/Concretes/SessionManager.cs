using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Session;
using Business.Dtos.Responses.Session;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;


namespace Business.Concretes
{
    public class SessionManager : ISessionService
    {
        IMapper _mapper;
        ISessionDal _sessionDal;

        public SessionManager(IMapper mapper, ISessionDal sessionDal)
        {
            _mapper = mapper;
            _sessionDal = sessionDal;
        }

        public async Task<CreatedSessionResponse> AddAsync(CreateSessionRequest createSessionRequest)
        {
            Session session = _mapper.Map<Session>(createSessionRequest);
            var createdSession = await _sessionDal.AddAsync(session);
            CreatedSessionResponse result = _mapper.Map<CreatedSessionResponse>(session);
            return result;
        }

        public async Task<DeletedSessionResponse> DeleteAsync(DeleteSessionRequest deleteSessionRequest)
        {
            Session session = await _sessionDal.GetAsync(s => s.Id == deleteSessionRequest.Id);
            var deletedSession = await _sessionDal.DeleteAsync(session);
            DeletedSessionResponse deletedSessionResponse = _mapper.Map<DeletedSessionResponse>(deletedSession);
            return deletedSessionResponse;
        }

        public async Task<GetSessionResponse> GetByIdAsync(GetSessionRequest getSessionRequest)
        {
            var result = await _sessionDal.GetAsync(s => s.Id == getSessionRequest.Id);
            return _mapper.Map<GetSessionResponse>(result);
        }

        public async Task<IPaginate<GetListSessionResponse>> GetListAsync(PageRequest pageRequest)
        {
            var result = await _sessionDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
            return _mapper.Map<IPaginate<GetListSessionResponse>>(result);
        }

        public async Task<UpdatedSessionResponse> UpdateAsync(UpdateSessionRequest updateSessionRequest)
        {
            Session session = _mapper.Map<Session>(updateSessionRequest);
            var updatedSession = await _sessionDal.UpdateAsync(session);
            UpdatedSessionResponse updatedSessionResponse = _mapper.Map<UpdatedSessionResponse>(updatedSession);
            return updatedSessionResponse;

        }
    }
}
