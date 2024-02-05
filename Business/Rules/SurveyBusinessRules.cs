using Core.Business.Rules;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;


public class SurveyBusinessRules : BaseBusinessRules<Survey>
{
    ISurveyDal _surveyDal;
    public SurveyBusinessRules(ISurveyDal surveyDal) : base(surveyDal)
    {
        _surveyDal = surveyDal;
    }
}
