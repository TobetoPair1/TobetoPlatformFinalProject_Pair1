using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.InstructorSession;
using Business.Dtos.Responses.InstructorSession;
using Business.Dtos.Responses.Session;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes
{
	public class InstructorSessionManager : IInstructorSessionService
    {
        IMapper _mapper;
        IInstructorSessionDal _instructorSessionDal;

        public InstructorSessionManager(IMapper mapper, IInstructorSessionDal instructorSessionDal)
        {
            _mapper = mapper;
            _instructorSessionDal = instructorSessionDal;
        }
        public async Task<CreatedInstructorSessionResponse> AddAsync(CreateInstructorSessionRequest createInstructorSessionRequest)
        {
            InstructorSession instructorSession = _mapper.Map<InstructorSession>(createInstructorSessionRequest);
            var createdInstructorSession = await _instructorSessionDal.AddAsync(instructorSession);
            CreatedInstructorSessionResponse result = _mapper.Map<CreatedInstructorSessionResponse>(createdInstructorSession);
            return result;
        }

        public async Task<DeletedInstructorSessionResponse> DeleteAsync(DeleteInstructorSessionRequest deleteInstructorSessionRequest)
        {
            InstructorSession instructorSession = await _instructorSessionDal.GetAsync(Is => Is.InstructorId == deleteInstructorSessionRequest.InstructorId && Is.SessionId == deleteInstructorSessionRequest.SessionId);
            var deletedInstructorSession = await _instructorSessionDal.DeleteAsync(instructorSession);
            DeletedInstructorSessionResponse result = _mapper.Map<DeletedInstructorSessionResponse>(deletedInstructorSession);
            return result;
        }

        public async Task<GetInstructorSessionResponse> GetByIdAsync(GetInstructorSessionRequest getInstructorSessionRequest)
        {
            var result = await _instructorSessionDal.GetAsync(Is => Is.InstructorId == getInstructorSessionRequest.InstructorId &&  Is.SessionId == getInstructorSessionRequest.SessionId);
            return _mapper.Map<GetInstructorSessionResponse>(result);
        }

        public async Task<IPaginate<GetListInstructorSessionResponse>> GetListAsync(PageRequest pageRequest)
        {
            var result = await _instructorSessionDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
            return _mapper.Map<Paginate<GetListInstructorSessionResponse>>(result);
        }

        public async Task<IPaginate<GetListSessionResponse>> GetListByInstructorIdAsync(Guid instructorId, PageRequest pageRequest)
        {
            var instructorSessions = await _instructorSessionDal.GetListAsync(ins => ins.InstructorId == instructorId, include: ins => ins.Include(ins => ins.Session).Include(ins => ins.Session.LiveContent), index: pageRequest.PageIndex, size: pageRequest.PageSize);

            var sessions = _mapper.Map<Paginate<GetListSessionResponse>>(instructorSessions);
            return sessions;
        }

        public async Task<UpdatedInstructorSessionResponse> UpdateAsync(UpdateInstructorSessionRequest updateInstructorSessionRequest)
        {
            InstructorSession instructorSession = _mapper.Map<InstructorSession>(updateInstructorSessionRequest);
            var updatedInstructorSession = await _instructorSessionDal.UpdateAsync(instructorSession);
            UpdatedInstructorSessionResponse updatedInstructorSessionResponse = _mapper.Map<UpdatedInstructorSessionResponse>(updatedInstructorSession);
            return updatedInstructorSessionResponse;
        }
    }
}
