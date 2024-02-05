using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;

namespace Business.Rules;

public class ExamQuestionBusinessRules : BaseBusinessRules<ExamQuestion>
{
	IExamQuestionDal _examQuestionDal;
	public ExamQuestionBusinessRules(IExamQuestionDal examQuestionDal) : base(examQuestionDal)
	{
		_examQuestionDal = examQuestionDal;
	}
	public async Task<ExamQuestion> CheckIfExistsWithForeignKey(Guid examId, Guid questionId)
	{
		ExamQuestion entity = await _examQuestionDal.GetAsync(eq => eq.ExamId == examId && eq.QuestionId == questionId);
		if (entity != null)
		{
			throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
		}
		return entity;
	}
}
