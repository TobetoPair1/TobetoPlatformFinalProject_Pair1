using Core.Business.Rules;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;

public class ExamBusinessRules : BaseBusinessRules<Exam>
{
    IExamDal _examDal;
    public ExamBusinessRules(IExamDal examDal) : base(examDal)
    {
        _examDal = examDal;
    }
}
