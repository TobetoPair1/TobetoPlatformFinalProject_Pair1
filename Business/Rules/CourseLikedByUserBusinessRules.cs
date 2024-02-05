using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;

namespace Business.Rules;

public class CourseLikedByUserBusinessRules : BaseBusinessRules<CourseLikedByUser>
{
	ICourseLikedByUserDal _courseLikedByUserDal;
	public CourseLikedByUserBusinessRules(ICourseLikedByUserDal courseLikedByUserDal) : base(courseLikedByUserDal)
	{
		_courseLikedByUserDal = courseLikedByUserDal;
	}
	public async Task<CourseLikedByUser> CheckIfExistsWithForeignKey(Guid userId, Guid courseId)
	{
		CourseLikedByUser entity = await _courseLikedByUserDal.GetAsync(clbu => clbu.UserId == userId && clbu.CourseId == courseId);
		if (entity != null)
		{
			throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
		}
		return entity;
	}
}