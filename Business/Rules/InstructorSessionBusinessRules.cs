using Core.Business.Rules;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;

namespace Business.Rules
{
    public class InstructorSessionBusinessRules:BaseBusinessRules<InstructorSession>
    {
        IInstructorSessionDal _instructorSessionDal;
        public InstructorSessionBusinessRules(IInstructorSessionDal instructorSessionDal) : base(instructorSessionDal)
        {
            _instructorSessionDal = instructorSessionDal;
        }
    }
}
