using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Exam;
using Business.Dtos.Requests.UserExam;
using Business.Dtos.Responses.Exam;
using Business.Dtos.Responses.UserExam;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class ExamManager : IExamService
{
    IMapper _mapper;
    IUserExamService _userExamService;
    IExamDal _examDal;
	public ExamManager(IMapper mapper, IExamDal examDal, IUserExamService userExamService)
	{
		_examDal = examDal;
		_mapper = mapper;
        _userExamService = userExamService;
	}
	public async Task<CreatedExamResponse> AddAsync(CreateExamRequest createExamRequest)
    {
        Exam exam = _mapper.Map<Exam>(createExamRequest);
        var createdExam = await _examDal.AddAsync(exam);
        CreatedExamResponse result = _mapper.Map<CreatedExamResponse>(createdExam);
        return result;
    }

    public async Task<CreatedUserExamResponse> AssignExamAsync(CreateUserExamRequest createUserExamRequest)
    {
        return await _userExamService.AddAsync(createUserExamRequest);
    }

    public async Task<DeletedExamResponse> DeleteAsync(DeleteExamRequest deleteExamRequest)
    {
        Exam exam = await _examDal.GetAsync(e => e.Id == deleteExamRequest.Id);
        var deletedExam = await _examDal.DeleteAsync(exam);
        DeletedExamResponse result = _mapper.Map<DeletedExamResponse>(deletedExam);
        return result;
    }

    public async Task<GetExamResponse> GetByIdAsync(GetExamRequest getExamRequest)
    {
        var result = await _examDal.GetAsync(a => a.Id == getExamRequest.Id);
        return _mapper.Map<GetExamResponse>(result);
    }

    public async Task<IPaginate<GetListExamResponse>> GetListByUserIdAsync(Guid userId, PageRequest pageRequest)
    {
        return await _userExamService.GetListByUserIdAsync(userId, pageRequest);
    }

    public async Task<IPaginate<GetListExamResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _examDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListExamResponse>>(result);
    }
	public async Task<UpdatedExamResponse> UpdateAsync(UpdateExamRequest updateExamRequest)
    {
        Exam exam = _mapper.Map<Exam>(updateExamRequest);
        var updatedExam = await _examDal.UpdateAsync(exam);
        UpdatedExamResponse updatedExamResponse = _mapper.Map<UpdatedExamResponse>(updatedExam);
        return updatedExamResponse;
    }
}
