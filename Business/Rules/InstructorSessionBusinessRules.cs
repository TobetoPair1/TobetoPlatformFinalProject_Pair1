using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
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
		public async Task<InstructorSession> CheckIfExistsWithForeignKey(Guid instructorId, Guid sessionId)
		{
			InstructorSession entity = await _instructorSessionDal.GetAsync(ise => ise.InstructorId == instructorId && ise.SessionId == sessionId);
			if (entity == null)
			{
				throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
			}
			return entity;
		}
	}
}
