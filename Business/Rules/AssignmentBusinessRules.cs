using Core.Business.Rules;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;

public class AssignmentBusinessRules:BaseBusinessRules<Assignment>
{
    IAssignmentDal _assignmentDal;
    public AssignmentBusinessRules(IAssignmentDal assignmentDal):base(assignmentDal)
    {
        _assignmentDal = assignmentDal;
    }
}
