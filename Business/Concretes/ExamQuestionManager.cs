using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.ExamQuestion;
using Business.Dtos.Responses.ExamQuestion;
using Business.Dtos.Responses.Question;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class ExamQuestionManager : IExamQuestionService
{
	IExamQuestionDal _examQuestionDal;
	IMapper _mapper;
	ExamQuestionBusinessRules _examQuestionBusinessRules;
	public ExamQuestionManager(IExamQuestionDal examQuestionDal, IMapper mapper, ExamQuestionBusinessRules examQuestionBusinessRules)
	{
		_examQuestionDal = examQuestionDal;
		_mapper = mapper;
		_examQuestionBusinessRules = examQuestionBusinessRules;
	}

	public async Task<CreatedExamQuestionResponse> AddAsync(CreateExamQuestionRequest createExamQuestionRequest)
	{
		ExamQuestion examQuestion = _mapper.Map<ExamQuestion>(createExamQuestionRequest);
		var createdExamQuestion = await _examQuestionDal.AddAsync(examQuestion);
		CreatedExamQuestionResponse createdUserSkillResponse = _mapper.Map<CreatedExamQuestionResponse>(createdExamQuestion);
		return createdUserSkillResponse;
	}

    public Task<CreatedExamQuestionResponse> AssignExamAsync(CreateExamQuestionRequest createExamQuestionRequest)
    {
        throw new NotImplementedException();
    }

    public async Task<DeletedExamQuestionResponse> DeleteAsync(DeleteExamQuestionRequest deleteExamQuestionRequest)
	{
		ExamQuestion examQuestion = await _examQuestionBusinessRules.CheckIfExistsWithForeignKey(deleteExamQuestionRequest.ExamId, deleteExamQuestionRequest.QuestionId);
		var deletedExamQuestion = await _examQuestionDal.DeleteAsync(examQuestion, true);
		DeletedExamQuestionResponse deletedExamQuestionResponse = _mapper.Map<DeletedExamQuestionResponse>(deletedExamQuestion);
		return deletedExamQuestionResponse;
	}

	public async Task<IPaginate<GetListExamQuestionResponse>> GetListAsync(PageRequest pageRequest)
	{
		var result = await _examQuestionDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize, include: eq => eq.Include(eq =>eq.Exam).Include(eq=>eq.Question));
		return _mapper.Map<Paginate<GetListExamQuestionResponse>>(result);
	}

    public async Task<IPaginate<GetListQuestionResponse>> GetListByExamIdAsync(Guid examId, PageRequest pageRequest)
    {
        var examQuestion = await _examQuestionDal.GetListAsync(eq => eq.ExamId == examId, include: eq => eq.Include(eq => eq.Question), index: pageRequest.PageIndex, size: pageRequest.PageSize);
        var questions = _mapper.Map<Paginate<GetListQuestionResponse>>(examQuestion);
        return questions;
    }
}
