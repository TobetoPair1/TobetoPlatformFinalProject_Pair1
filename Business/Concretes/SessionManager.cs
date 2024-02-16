using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.InstructorSession;
using Business.Dtos.Requests.Session;
using Business.Dtos.Responses.InstructorSession;
using Business.Dtos.Responses.Session;
using Business.Rules;
using Core.Aspects.Autofac.SecuredOperation;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;


namespace Business.Concretes;

public class SessionManager : ISessionService
{
    IMapper _mapper;
    ISessionDal _sessionDal;
    IInstructorSessionService _instructorSessionService;
    SessionBusinessRules _sessionBusinessRules;
    public SessionManager(IMapper mapper, ISessionDal sessionDal, IInstructorSessionService instructorSessionService, SessionBusinessRules sessionBusinessRules)
    {
        _mapper = mapper;
        _sessionDal = sessionDal;
        _instructorSessionService = instructorSessionService;
        _sessionBusinessRules = sessionBusinessRules;
    }

    [SecuredOperation("admin")]
    public async Task<CreatedSessionResponse> AddAsync(CreateSessionRequest createSessionRequest)
    {
        Session session = _mapper.Map<Session>(createSessionRequest);
        var createdSession = await _sessionDal.AddAsync(session);
        CreatedSessionResponse result = _mapper.Map<CreatedSessionResponse>(session);
        return result;
    }

    public async Task<CreatedInstructorSessionResponse> AssignSessionAsync(CreateInstructorSessionRequest createInstructorSessionRequest)
    {
        return await _instructorSessionService.AddAsync(createInstructorSessionRequest);
    }


    public async Task<IPaginate<GetListSessionResponse>> GetListByInstructorIdAsync(Guid instructorId, PageRequest pageRequest)
    {
        return await _instructorSessionService.GetListByInstructorIdAsync(instructorId, pageRequest);
    }

    [SecuredOperation("admin")]
    public async Task<DeletedSessionResponse> DeleteAsync(DeleteSessionRequest deleteSessionRequest)
    {
        Session session = await _sessionBusinessRules.CheckIfExistsById(deleteSessionRequest.Id);
        var deletedSession = await _sessionDal.DeleteAsync(session);
        DeletedSessionResponse deletedSessionResponse = _mapper.Map<DeletedSessionResponse>(deletedSession);
        return deletedSessionResponse;
    }

    public async Task<GetSessionResponse> GetByIdAsync(GetSessionRequest getSessionRequest)
    {
        var result = await _sessionDal.GetAsync(s => s.Id == getSessionRequest.Id);
        return _mapper.Map<GetSessionResponse>(result);
    }

    [SecuredOperation("admin")]

    public async Task<IPaginate<GetListSessionResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _sessionDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListSessionResponse>>(result);
    }

    [SecuredOperation("admin")]

    public async Task<UpdatedSessionResponse> UpdateAsync(UpdateSessionRequest updateSessionRequest)
    {
        await _sessionBusinessRules.CheckLiveContentIfExists(updateSessionRequest.Id);
        Session session = await _sessionBusinessRules.CheckIfExistsById(updateSessionRequest.Id);
        _mapper.Map(updateSessionRequest, session);
        var updatedSession = await _sessionDal.UpdateAsync(session);
        UpdatedSessionResponse updatedSessionResponse = _mapper.Map<UpdatedSessionResponse>(updatedSession);
        return updatedSessionResponse;

    }
}
