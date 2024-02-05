using Core.Business.Rules;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;

public class AnswerBusinessRules : BaseBusinessRules<Answer>
{
    IAnswerDal _answerDal;
    public AnswerBusinessRules(IAnswerDal answerDal):base(answerDal)
    {
        _answerDal = answerDal;
    }
}
