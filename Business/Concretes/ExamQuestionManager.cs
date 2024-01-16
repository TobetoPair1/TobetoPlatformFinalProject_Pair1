using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.ExamQuestion;
using Business.Dtos.Responses.ExamQuestion;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTable;
using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

    public class ExamQuestionManager : IExamQuestionService
{
	IExamQuestionDal _examQuastiondal;
	IMapper _mapper;

	public ExamQuestionManager(IExamQuestionDal examQuastiondal, IMapper mapper)
	{
		_examQuastiondal = examQuastiondal;
		_mapper = mapper;
	}

	public async Task<CreatedExamQuestionResponse> AddAsync(CreateExamQuestionRequest createExamQuestionRequest)
	{
		ExamQuestion examQuestion = _mapper.Map<ExamQuestion>(createExamQuestionRequest);
		var createdExamQuestion = await _examQuastiondal.AddAsync(examQuestion);
		CreatedExamQuestionResponse createdUserSkillResponse = _mapper.Map<CreatedExamQuestionResponse>(createdExamQuestion);
		return createdUserSkillResponse;
	}

	public async Task<DeletedExamQuestionResponse> DeleteAsync(DeleteExamQuestionRequest deleteExamQuestionRequest)
	{
		ExamQuestion examQuestion = await _examQuastiondal.GetAsync(
			eq =>
			eq.ExamId == deleteExamQuestionRequest.ExamId
			&&
			eq.QuestionId == deleteExamQuestionRequest.QuestionId);
		var deletedExamQuestion = await _examQuastiondal.DeleteAsync(examQuestion, true);
		DeletedExamQuestionResponse deletedExamQuestionResponse = _mapper.Map<DeletedExamQuestionResponse>(deletedExamQuestion);
		return deletedExamQuestionResponse;
	}

	public async Task<IPaginate<GetListExamQuestionResponse>> GetListAsync(PageRequest pageRequest)
	{
		var result = await _examQuastiondal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize, include: eq => eq.Include(eq => new { eq.Exam,eq.Question}));
		return _mapper.Map<Paginate<GetListExamQuestionResponse>>(result);
	}
}
