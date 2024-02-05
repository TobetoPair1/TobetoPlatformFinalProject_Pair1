using Business.Abstracts;
using Business.Dtos.Requests.Question;
using Business.Dtos.Responses.Question;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;

public class AnswerBusinessRules : BaseBusinessRules<Answer>
{
    IAnswerDal _answerDal;
    IQuestionService _questionService;
    public AnswerBusinessRules(IAnswerDal answerDal, IQuestionService questionService) : base(answerDal)
    {
        _answerDal = answerDal;
        _questionService = questionService;
    }
    public async Task CheckQuestionIfExists(Guid questionId)
    {
        GetQuestionResponse question = await _questionService.GetByIdAsync(new GetQuestionRequest { Id = questionId });
        if (question == null)
        {
            throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
        }
    }
}