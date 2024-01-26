using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.ExamQuestion;
using Business.Dtos.Responses.ExamQuestion;
using Business.Dtos.Responses.Question;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class ExamQuestionManager : IExamQuestionService
{
	IExamQuestionDal _examQuestionDal;
	IMapper _mapper;

	public ExamQuestionManager(IExamQuestionDal examQuestionDal, IMapper mapper)
	{
        _examQuestionDal = examQuestionDal;
		_mapper = mapper;
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
		ExamQuestion examQuestion = await _examQuestionDal.GetAsync(
			eq =>
			eq.ExamId == deleteExamQuestionRequest.ExamId
			&&
			eq.QuestionId == deleteExamQuestionRequest.QuestionId);
		var deletedExamQuestion = await _examQuestionDal.DeleteAsync(examQuestion, true);
		DeletedExamQuestionResponse deletedExamQuestionResponse = _mapper.Map<DeletedExamQuestionResponse>(deletedExamQuestion);
		return deletedExamQuestionResponse;
	}

	public async Task<IPaginate<GetListExamQuestionResponse>> GetListAsync(PageRequest pageRequest)
	{
		var result = await _examQuestionDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize, include: eq => eq.Include(eq => new { eq.Exam,eq.Question}));
		return _mapper.Map<Paginate<GetListExamQuestionResponse>>(result);
	}

    public async Task<IPaginate<GetListQuestionResponse>> GetListByExamIdAsync(Guid examId, PageRequest pageRequest)
    {
        var examQuestion = await _examQuestionDal.GetListAsync(eq => eq.ExamId == examId, include: eq => eq.Include(eq => eq.Question), index: pageRequest.PageIndex, size: pageRequest.PageSize);
        var questions = _mapper.Map<Paginate<GetListQuestionResponse>>(examQuestion);
        return questions;
    }
}
