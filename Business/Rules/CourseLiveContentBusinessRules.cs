using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;

namespace Business.Rules;

public class CourseLiveContentBusinessRules : BaseBusinessRules<CourseLiveContent>
{
	ICourseLiveContentDal _courseLiveContentDal;
	public CourseLiveContentBusinessRules(ICourseLiveContentDal courseLiveContentDal) : base(courseLiveContentDal)
	{
		_courseLiveContentDal = courseLiveContentDal;
	}
	public async Task<CourseLiveContent> CheckIfExistsWithForeignKey(Guid courseId, Guid ContentId)
	{
		CourseLiveContent entity = await _courseLiveContentDal.GetAsync(clbu => clbu.CourseId == courseId && clbu.LiveContentId == ContentId);
		if (entity == null)
		{
			throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
		}
		return entity;
	}
}