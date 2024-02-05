using Core.Business.Rules;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;

public class HomeworkBusinessRules : BaseBusinessRules<Homework>
{
    IHomeworkDal _homeworkDal;
    public HomeworkBusinessRules(IHomeworkDal homeworkDal) : base(homeworkDal)
    {
        _homeworkDal = homeworkDal;
    }
}
