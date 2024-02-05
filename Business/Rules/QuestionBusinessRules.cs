using Core.Business.Rules;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class QuestionBusinessRules : BaseBusinessRules<Question>
    {
        IQuestionDal _questionDal;
        public QuestionBusinessRules(IQuestionDal questionDal) : base(questionDal)
        {
            _questionDal = questionDal;
        }
    }
}
