using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;

namespace Business.Rules;

public class CourseFavouritedByUserBusinessRules:BaseBusinessRules<CourseFavouritedByUser>
{
        ICourseFavouritedByUserDal _courseFavouritedByUserDal;
	public CourseFavouritedByUserBusinessRules(ICourseFavouritedByUserDal courseFavouritedByUserDal):base(courseFavouritedByUserDal)
	{
		_courseFavouritedByUserDal = courseFavouritedByUserDal;
	}
	public async Task<CourseFavouritedByUser> CheckIfExistsWithForeignKey(Guid userId, Guid courseId)
	{
		CourseFavouritedByUser entity = await _courseFavouritedByUserDal.GetAsync(cfbu => cfbu.UserId == userId && cfbu.CourseId == courseId);
		if (entity != null)
		{
			throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
		}
		return entity;
	}
}
