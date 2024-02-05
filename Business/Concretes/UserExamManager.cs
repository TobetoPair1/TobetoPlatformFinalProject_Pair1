using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.UserExam;
using Business.Dtos.Responses.Course;
using Business.Dtos.Responses.Exam;
using Business.Dtos.Responses.UserExam;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class UserExamManager : IUserExamService
{
    IMapper _mapper;
    IUserExamDal _userExamDal;
    UserExamRules _userExamRules;

    public UserExamManager(IMapper mapper, IUserExamDal userExamDal, UserExamRules userExamRules)
    {
        _mapper = mapper;
        _userExamDal = userExamDal;
        _userExamRules = userExamRules;
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
        UserExam userExam = await _userExamRules.CheckIfExistsById(deleteUserExamRequest.UserId, deleteUserExamRequest.ExamId);
        var deletedUserExam = await _userExamDal.DeleteAsync(userExam, true);
        DeletedUserExamResponse deletedUserExamResponse = _mapper.Map<DeletedUserExamResponse>(deletedUserExam);
        return deletedUserExamResponse;
    }

    public async Task<GetUserExamResponse> GetByIdAsync(GetUserExamRequest getUserExamRequest)
    {
        var result = await _userExamDal.GetAsync(ue => ue.UserId == getUserExamRequest.UserId && ue.ExamId == getUserExamRequest.ExamId, include: ue => ue.Include(ue => ue.Exam));
        return _mapper.Map<GetUserExamResponse>(result);
    }

    public async Task<IPaginate<GetListExamResponse>> GetListByUserIdAsync(Guid userId, PageRequest pageRequest)
    {
        var userExams = await _userExamDal.GetListAsync(ue => ue.UserId == userId, include: ue => ue.Include(ue => ue.Exam), index: pageRequest.PageIndex, size: pageRequest.PageSize);

        var exams = _mapper.Map<Paginate<GetListExamResponse>>(userExams);
        return exams;
    }

    public async Task<IPaginate<GetListUserExamResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _userExamDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize, include: ue => ue.Include(ue => ue.Exam));
        return _mapper.Map<Paginate<GetListUserExamResponse>>(result);
    }
}
