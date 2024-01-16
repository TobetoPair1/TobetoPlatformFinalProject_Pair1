using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.UserExam;
using Business.Dtos.Responses.UserExam;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTable;
using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes
{
    public class UserExamManager : IUserExamService
    {
        IMapper _mapper;
        IUserExamDal _userExamDal;

        public UserExamManager(IMapper mapper, IUserExamDal userExamDal)
        {
            _mapper = mapper;
            _userExamDal = userExamDal;
        }

        public async Task<CreatedUserExamResponse> AddAsync(CreateUserExamRequest createUserExamRequest)
        {
            UserExam userExam = _mapper.Map<UserExam>(createUserExamRequest);
            var createdUserExam = await _userExamDal.AddAsync(userExam);
            CreatedUserExamResponse createdUserExamResponse = _mapper.Map<CreatedUserExamResponse>(createdUserExam);
            return createdUserExamResponse;
        }

        public async Task<DeletedUserExamResponse> DeleteAsync(DeleteUserExamRequest deleteUserExamRequest)
        {
            UserExam userExam = await _userExamDal.GetAsync(ue => ue.UserId == deleteUserExamRequest.UserId && ue.ExamId == deleteUserExamRequest.ExamId);
            var deletedUserExam = await _userExamDal.DeleteAsync(userExam, true);
            DeletedUserExamResponse deletedUserExamResponse = _mapper.Map<DeletedUserExamResponse>(deletedUserExam);
            return deletedUserExamResponse;
        }

        public async Task<GetUserExamResponse> GetByIdAsync(GetUserExamRequest getUserExamRequest)
        {
            var result = await _userExamDal.GetAsync(ue=> ue.UserId == getUserExamRequest.UserId && ue.ExamId == getUserExamRequest.ExamId, include: ue => ue.Include(ue => ue.Exam));
            return _mapper.Map<GetUserExamResponse>(result);
        }

        public async Task<IPaginate<GetListUserExamResponse>> GetListAsync(PageRequest pageRequest)
        {
            var result = await _userExamDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize, include: ue => ue.Include(ue => ue.Exam));
            return _mapper.Map<Paginate<GetListUserExamResponse>>(result);
        }
    }
}
