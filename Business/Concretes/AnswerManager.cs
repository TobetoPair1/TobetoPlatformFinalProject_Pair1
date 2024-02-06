using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Answer;
using Business.Dtos.Responses.Answer;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class AnswerManager : IAnswerService
{
	IAnswerDal _answerDal;
	IMapper _mapper;
	AnswerBusinessRules _answerBusinessRules;

    public AnswerManager(IAnswerDal answerDal, IMapper mapper, AnswerBusinessRules answerBusinessRules)
    {
        _answerDal = answerDal;
        _mapper = mapper;
        _answerBusinessRules = answerBusinessRules;
    }

    public async Task<CreatedAnswerResponse> AddAsync(CreateAnswerRequest createAnswerRequest)
	{			
		Answer answer = _mapper.Map<Answer>(createAnswerRequest);
		var createdAnswer = await _answerDal.AddAsync(answer);
		CreatedAnswerResponse createdAnswerResponse = _mapper.Map<CreatedAnswerResponse>(createdAnswer);
		return createdAnswerResponse;
	}

	public async Task<DeletedAnswerResponse> DeleteAsync(DeleteAnswerRequest deleteAnswerRequest)
	{
		Answer answer = await _answerBusinessRules.CheckIfExistsById(deleteAnswerRequest.Id);
		var deletedAnswer = await _answerDal.DeleteAsync(answer);
		DeletedAnswerResponse deletedAnswerResponse = _mapper.Map<DeletedAnswerResponse>(deletedAnswer);
		return deletedAnswerResponse;
	}

	public async Task<GetAnswerResponse> GetByIdAsync(GetAnswerRequest getAnswerRequest)
	{
		var result = await _answerDal.GetAsync(a => a.Id == getAnswerRequest.Id, include: a => a.Include(a => a.Question));
		return _mapper.Map<GetAnswerResponse>(result);
	}

	public async Task<IPaginate<GetListAnswerResponse>> GetListAsync(PageRequest pageRequest)
	{
		var result = await _answerDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize, include: a => a.Include(a => a.Question));
		return _mapper.Map<Paginate<GetListAnswerResponse>>(result);
	}

	public async Task<IPaginate<GetListAnswerResponse>> GetListByQuestionIdAsync(PageRequest pageRequest, Guid questionId)
	{
		var result = await _answerDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize,include:a=>a.Include(a=>a.Question));
		return _mapper.Map<Paginate<GetListAnswerResponse>>(result);
	}

	public async Task<UpdatedAnswerResponse> UpdateAsync(UpdateAnswerRequest updateAnswerRequest)
	{
        await _answerBusinessRules.CheckQuestionIfExists(updateAnswerRequest.Id);
        Answer answer = await _answerBusinessRules.CheckIfExistsById(updateAnswerRequest.Id);
		_mapper.Map(updateAnswerRequest,answer);
		var updatedAnswer = await _answerDal.UpdateAsync(answer);
		UpdatedAnswerResponse updatedAnswerResponse = _mapper.Map<UpdatedAnswerResponse>(updatedAnswer);
		return updatedAnswerResponse;
	}
}