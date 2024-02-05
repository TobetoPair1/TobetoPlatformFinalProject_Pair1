using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;

namespace Business.Rules;

public class CourseAsyncContentBusinessRules : BaseBusinessRules<CourseAsyncContent>
{
	ICourseAsyncContentDal _courseAsyncContentDal;
	public CourseAsyncContentBusinessRules(ICourseAsyncContentDal courseAsyncContentDal) : base(courseAsyncContentDal)
	{
		_courseAsyncContentDal = courseAsyncContentDal;
	}
	public async Task<CourseAsyncContent> CheckIfExistsWithForeignKey(Guid courseId, Guid ContentId)
	{
		CourseAsyncContent entity = await _courseAsyncContentDal.GetAsync(cac => cac.CourseId == courseId && cac.AsyncContentId == ContentId);
		if (entity != null)
		{
			throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
		}
		return entity;
	}
}
