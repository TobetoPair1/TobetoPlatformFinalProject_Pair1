using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.ExamQuestion;
using Business.Dtos.Requests.PersonalInfo;
using Business.Dtos.Requests.Question;
using Business.Dtos.Responses.ExamQuestion;
using Business.Dtos.Responses.Question;
using Business.Rules;
using Core.Aspects.Autofac.SecuredOperation;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class QuestionManager: IQuestionService
{
    IMapper _mapper;
    IQuestionDal _questionDal;
    IExamQuestionService _examQuestionService;
    QuestionBusinessRules _questionBusinessRules;

    public QuestionManager(IMapper mapper, IQuestionDal questionDal, IExamQuestionService examQuestionService, QuestionBusinessRules questionBusinessRules)
    {
        _mapper = mapper;
        _questionDal = questionDal;
        _examQuestionService = examQuestionService;
        _questionBusinessRules = questionBusinessRules;
    }

    [SecuredOperation("admin")]
    public async Task<CreatedQuestionResponse> AddAsync(CreateQuestionRequest createQuestionRequest)
    {
        Question question = _mapper.Map<Question>(createQuestionRequest);
        var createdQuestion = await _questionDal.AddAsync(question);
        CreatedQuestionResponse createdQuestionResponse = _mapper.Map<CreatedQuestionResponse>(createdQuestion);
        return createdQuestionResponse;
    }

    public async Task<CreatedExamQuestionResponse> AssignQuestionAsync(CreateExamQuestionRequest createExamQuestionRequest)
    {
        return await _examQuestionService.AddAsync(createExamQuestionRequest);
    }

    [SecuredOperation("admin")]
    public async Task<DeletedQuestionResponse> DeleteAsync(DeleteQuestionRequest deleteQuestionRequest)
    {
        Question question = await _questionBusinessRules.CheckIfExistsById(deleteQuestionRequest.Id);
        var deletedQuestion = await _questionDal.DeleteAsync(question);
        DeletedQuestionResponse deletedQuestionResponse = _mapper.Map<DeletedQuestionResponse>(deletedQuestion);
        return deletedQuestionResponse;
    }

    public async Task<GetQuestionResponse> GetByIdAsync(GetQuestionRequest getQuestionRequest)
    {
         var result = await _questionDal.GetAsync(q => q.Id == getQuestionRequest.Id);
         return _mapper.Map<GetQuestionResponse>(result);
    }

    [SecuredOperation("admin")]
    public async Task<IPaginate<GetListQuestionResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _questionDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListQuestionResponse>>(result);
    }

    public async Task<IPaginate<GetListQuestionResponse>> GetListByExamIdAsync(Guid examId, PageRequest pageRequest)
    {
        return await _examQuestionService.GetListByExamIdAsync(examId, pageRequest);
    }

    [SecuredOperation("admin")]
    public async Task<UpdatedQuestionResponse> UpdateAsync(UpdateQuestionRequest updateQuestionRequest)
    {
        Question question = await _questionBusinessRules.CheckIfExistsById(updateQuestionRequest.Id);
        _mapper.Map(updateQuestionRequest, question);
        var updatedQuestion = await _questionDal.UpdateAsync(question);
        UpdatedQuestionResponse updatedQuestionResponse = _mapper.Map<UpdatedQuestionResponse>(updatedQuestion);
        return updatedQuestionResponse;
    }
}
