using Core.Business.Rules;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class OperationClaimBusinessRules : BaseBusinessRules<OperationClaim>
    {
        IOperationClaimDal _operationClaimDal;
        public OperationClaimBusinessRules(IOperationClaimDal operationClaimDal) : base(operationClaimDal)
        {
            _operationClaimDal = operationClaimDal;
        }
        
        
    }
}
